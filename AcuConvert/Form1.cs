using System.ComponentModel;
using AcuConvert.Core.Interfaces;
using System.Data.SqlClient;
using AcuConvert.Core.Models;
using AcuConvert.Core.Models.Data;
using AcuConvert.Core.Models.Data.DB;
using AcuConvert.Core.Workers;

namespace AcuConvert;

public partial class Form1 : Form
{
    public           BindingList<SyncMapping> SyncMappings { get; set; }
    public           BindingList<SyncRow>     SyncRows     { get; set; }
    public           BindingList<SyncField>   SyncFields   { get; set; }
    public           BindingList<string>      AcuFields    { get; set; }
    public           SyncInstance             Instance     { get; set; }
    private readonly ISyncRepository          _syncRepository;
    private readonly ISyncWorker              _syncWorker;
    private readonly IAcumaticaConnector      _acumaticaConnector;
    private readonly ILegacyConnector         _legacyConnector;
    private readonly RecordReconciliator      _reconciliator;

    public Form1(ISyncRepository     syncRepository,
                 ISyncWorker         syncWorker,
                 IAcumaticaConnector acumaticaConnector,
                 ILegacyConnector    legacyConnector,
                 RecordReconciliator reconciliator)
    {
        _syncRepository     = syncRepository;
        _syncWorker         = syncWorker;
        _acumaticaConnector = acumaticaConnector;
        _legacyConnector    = legacyConnector;
        _reconciliator      = reconciliator;
        InitializeComponent();
        SyncFields = new BindingList<SyncField>();
        AcuFields = new BindingList<string>();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        SyncMappings             = new BindingList<SyncMapping>(_syncRepository.GetSyncMapping("Customer").ToList());
        grdMapping.DataSource = SyncMappings;

        SyncRows                 = new BindingList<SyncRow>(_syncRepository.GetSyncDataSet("Customer").ToList());
        grdExceptions.DataSource = SyncRows;
        cmbCustEndpointfields.DataSource = AcuFields;
        this.Instance = _syncRepository.GetSyncInstance("customer");
        _acumaticaConnector.Initialize(new AcumaticaConnectionContext("https://hackathon.acumatica.com/iota", "admin", "123", "", "Demo", "1.0", "Customer", "Customer"));
    }

    private void refreshLegacySchema_Click(object sender, EventArgs e)
    {
        // Sync schema
        var items = _legacyConnector.GetSchema(new LegacyConnectionContext()
        {
            AuthenticationValues = _syncRepository.GetSourceConnectionSettings().ToArray(),
            QueryParameters = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("Query", this.txtFromCustomer.Text + " " + this.txtWhereCustomer.Text)
            }
        });

        foreach (var item in items)
        {
            if (SyncMappings.All(m => m.SourceField.Trim() != item.FieldName))
            {
                SyncMappings.Add(new SyncMapping()
                {
                    SourceField = item.FieldName,
                    InstanceID  = "Customer",
                    DestField   = string.Empty,
                    MappingID   = SyncMappings.Count + 1,
                    SourceValue = string.Empty
                });
            }
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        // Prepare data
        var items = _legacyConnector.GetDataSet(new LegacyConnectionContext()
        {
            AuthenticationValues = _syncRepository.GetSourceConnectionSettings().ToArray(),
            QueryParameters = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("Query", this.txtFromCustomer.Text + " " + this.txtWhereCustomer.Text),
                new KeyValuePair<string, string>("LastModifiedField", "a.UpdateDate")
            }
        }, dtCustomerLastRun.Value);

        // Dictionary<int, Row> rowDic = new Dictionary<int, Row>();
        // foreach (SyncRow row in SyncRows)
        // {
        //     rowDic.Add(row.RowNbr, new Row("Customer",row.RowNbr)
        //     {
        //         NoteId = row.NoteID
        //     });
        // }
        // _reconciliator.SyncRow();
        SyncRows.Clear();
        int rowNbr = 1;
        foreach (Row item in items)
        {
            SyncRows.Add(new SyncRow()
            {
                InstanceID = "Customer",
                RowNbr     = rowNbr,
                Selected   = false
            });

            foreach (KeyValuePair<string, Field> field in item.Fields)
            {
                SyncFields.Add(new SyncField()
                {
                    DataType        = "String",
                    InstanceID      = "Customer",
                    RowNbr          = rowNbr,
                    SourceFieldName = field.Value.FieldName,
                    Value           = field.Value.Value
                });
            }

            rowNbr++;
        }

        Instance.LastRun        = DateTime.Now;
        dtCustomerLastRun.Value = DateTime.Now;
    }

    private void btnRun_Click(object sender, EventArgs e)
    {
        try
        {
            Dictionary<string, SyncMapping> mappings = new Dictionary<string, SyncMapping>(
                SyncMappings.Select(a => new KeyValuePair<string, SyncMapping>(a.SourceField, a)));
            foreach (SyncRow row in SyncRows)
            {
                try
                {
                    var fields  = SyncFields.Where(f => f.RowNbr == row.RowNbr);
                    var destRow = new Row("Customer", row.RowNbr);
                    destRow.NoteId = row.NoteID;

                    foreach (SyncField field in fields)
                    {
                        Field destField;
                        if (mappings.TryGetValue(field.SourceFieldName, out SyncMapping value)
                         && !string.IsNullOrWhiteSpace(value?.DestField))
                        {
                            // We have mapping to dest field
                            if (!string.IsNullOrWhiteSpace(value.SourceValue))
                            {
                                // we have override
                                destField = new Field(value.DestField, "String", false)
                                {
                                    Value = value.SourceValue
                                };
                            }
                            else
                            {
                                destField = new Field(value.DestField, "String", false)
                                {
                                    Value = field.Value
                                };
                            }
                        }
                        else
                        {
                            continue;
                        }
                        destRow.AddField(destField);
                    }

                    row.NoteID = _acumaticaConnector.SendRow(destRow);
                    row.Processed    = true;
                    row.ErrorMessage = string.Empty;
                    row.Failed       = false;
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                    row.ErrorMessage = exception.Message;
                    row.Failed       = true;
                }
            }
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception);
            throw;
        }

        grdExceptions.DataSource = SyncRows;
        grdExceptions.Refresh();
    }

    private void refreshAcuSchema_Click(object sender, EventArgs e)
    {
        var fields = _acumaticaConnector.GetSchema("Customer");
        AcuFields.Clear();
        foreach (Field field in fields)
        {
            AcuFields.Add(field.FieldName);
        }
    }

    private void addAcuField_Click(object sender, EventArgs e)
    {
        var curRow = grdMapping.CurrentRow;
        curRow.Cells["Destfield"].Value = cmbCustEndpointfields.SelectedItem;
    }

    private void label8_Click(object sender, EventArgs e)
    {

    }
}