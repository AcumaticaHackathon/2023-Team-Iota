using AcuConvert.Core.Interfaces;
using System.Data.SqlClient;
using AcuConvert.Core.Models.Data.DB;

namespace AcuConvert;

public partial class Form1 : Form
{
    public List<SyncMapping> SyncMappings { get; set; }
    public List<SyncRow> SyncRows { get; set; }
    private readonly ISyncRepository     _syncRepository;
    private readonly ISyncWorker         _syncWorker;
    private readonly IAcumaticaConnector _acumaticaConnector;
    private readonly ILegacyConnector    _legacyConnector;

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
        SyncMappings             = _syncRepository.GetSyncMapping("Customer").ToList();
        dataGridView1.DataSource = SyncMappings;
        
        SyncRows                 = _syncRepository.GetSyncDataSet("Customer").ToList();
        grdExceptions.DataSource = SyncRows;

    }
}