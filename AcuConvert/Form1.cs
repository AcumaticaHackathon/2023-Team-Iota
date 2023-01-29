using System.ComponentModel;
using AcuConvert.Core.Interfaces;
using System.Data.SqlClient;
using AcuConvert.Core.Models;
using AcuConvert.Core.Models.Data.DB;

namespace AcuConvert;

public partial class Form1 : Form
{
    public           BindingList<SyncMapping> SyncMappings { get; set; }
    public           BindingList<SyncRow>     SyncRows     { get; set; }
    private readonly ISyncRepository          _syncRepository;
    private readonly ISyncWorker              _syncWorker;
    private readonly IAcumaticaConnector      _acumaticaConnector;
    private readonly ILegacyConnector         _legacyConnector;

    public Form1(ISyncRepository syncRepository,
                 ISyncWorker syncWorker,
                 IAcumaticaConnector acumaticaConnector,
                 ILegacyConnector legacyConnector)
    {
        _syncRepository       = syncRepository;
        _syncWorker           = syncWorker;
        _acumaticaConnector   = acumaticaConnector;
        _legacyConnector = legacyConnector;
        InitializeComponent();
        
    }
    
    private void Form1_Load(object sender, EventArgs e)
    {
        SyncMappings             = new BindingList<SyncMapping>(_syncRepository.GetSyncMapping("Customer").ToList());
        dataGridView1.DataSource = SyncMappings;
        
        SyncRows                 = new BindingList<SyncRow>(_syncRepository.GetSyncDataSet("Customer").ToList());
        grdExceptions.DataSource = SyncRows;

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
}