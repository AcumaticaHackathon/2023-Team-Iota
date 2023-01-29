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
    public           SyncInstance             Instance     { get; set; }
    private readonly ISyncRepository          _syncRepository;
    private readonly ISyncWorker              _syncWorker;
    private readonly IAcumaticaConnector      _acumaticaConnector;
    private readonly ILegacyConnector         _legacyConnector;
    private readonly RecordReconciliator      _reconciliator;

    public Form1(ISyncRepository syncRepository,
                 ISyncWorker syncWorker,
                 IAcumaticaConnector acumaticaConnector,
                 ILegacyConnector legacyConnector,
                 RecordReconciliator reconciliator)
    {
        _syncRepository     = syncRepository;
        _syncWorker         = syncWorker;
        _acumaticaConnector = acumaticaConnector;
        _legacyConnector    = legacyConnector;
        _reconciliator = reconciliator;
        InitializeComponent();
        
    }
    
    private void Form1_Load(object sender, EventArgs e)
    {
        SyncMappings             = new BindingList<SyncMapping>(_syncRepository.GetSyncMapping("Customer").ToList());
        dataGridView1.DataSource = SyncMappings;
        
        SyncRows                 = new BindingList<SyncRow>(_syncRepository.GetSyncDataSet("Customer").ToList());
        grdExceptions.DataSource = SyncRows;

        this.Instance = _syncRepository.GetSyncInstance("customer");

    }

    private void button3_Click(object sender, EventArgs e)
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
                    InstanceID = "Customer",
                    DestField = string.Empty,
                    MappingID = SyncMappings.Count + 1,
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
                new KeyValuePair<string, string>("Query", this.txtFromCustomer.Text + " " + this.txtWhereCustomer.Text)
            }
        }, Instance.LastRun ?? new DateTime(1900, 1, 1));

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
                RowNbr = rowNbr,
                Selected = false
            });

            foreach (KeyValuePair<string, Field> field in item.Fields)
            {
                SyncFields.Add(new SyncField()
                {
                    DataType = "String",
                    InstanceID = "Customer",
                    RowNbr = rowNbr,
                    SourceFieldName = field.Value.FieldName,
                    Value = field.Value.Value
                });
            }

            rowNbr++;
        }
        Instance.LastRun = DateTime.Now;
    }
}