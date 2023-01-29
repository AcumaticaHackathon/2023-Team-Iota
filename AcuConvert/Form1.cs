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

    public string sConnectorConnectString = "Data Source=(local);Initial Catalog=AcuConvert;User ID=sa;password=";
    string strExeFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;

    private void Form1_Load(object sender, EventArgs e)
    {
        SyncMappings = new List<SyncMapping>()
        {
            new SyncMapping()
            {
                SourceField= "source",
                DestField= "target",
            },
        };
        dataGridView1.DataSource = SyncMappings;


        SyncRows = new List<SyncRow>()
        {
            new SyncRow()
            {
                RowNbr = 100,
                NoteID = Guid.NewGuid(),
                Failed = 1,
                ErrorMessage = ""
            }
        };
        grdExceptions.DataSource = SyncRows;

    }

    private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void tabPage2_Click(object sender, EventArgs e)
    {

    }

    private void tabPage1_Click(object sender, EventArgs e)
    {

    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void lblSourceSQLConnection_Click(object sender, EventArgs e)
    {

    }

    private void lblDestinationURL_Click(object sender, EventArgs e)
    {

    }

    private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void lblSourceERP_Click(object sender, EventArgs e)
    {

    }

    private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void lblDestinationInstance_Click(object sender, EventArgs e)
    {

    }

    private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
    {

    }


}