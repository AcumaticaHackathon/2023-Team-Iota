using AcuConvert.Core.Interfaces;

namespace AcuConvert;

public partial class Form1 : Form
{
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