namespace AcuConvert;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lblSourceERP = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.lblDestinationURL = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblSourceSQLConnection = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabAR = new System.Windows.Forms.TabPage();
            this.grdExceptions = new System.Windows.Forms.DataGridView();
            this.grdMapping = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.addAcuField = new System.Windows.Forms.Button();
            this.refreshLegacySchema = new System.Windows.Forms.Button();
            this.cmbCustEndpointfields = new System.Windows.Forms.ComboBox();
            this.refreshAcuSchema = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dtCustomerLastRun = new System.Windows.Forms.DateTimePicker();
            this.lblWhere1 = new System.Windows.Forms.Label();
            this.txtWhereCustomer = new System.Windows.Forms.TextBox();
            this.lblSelect = new System.Windows.Forms.Label();
            this.txtFromCustomer = new System.Windows.Forms.TextBox();
            this.chkProcessCustomers = new System.Windows.Forms.CheckBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.grpCustomerAddress = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWhereCustAddr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSelectCustAddr = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabAP = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.tabGL = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.tabAR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdExceptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMapping)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.grpCustomerAddress.SuspendLayout();
            this.tabAP.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabGL.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSettings);
            this.tabControl1.Controls.Add(this.tabAR);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabAP);
            this.tabControl1.Controls.Add(this.tabGL);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(0, 5);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1628, 1140);
            this.tabControl1.TabIndex = 0;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.button2);
            this.tabSettings.Controls.Add(this.groupBox10);
            this.tabSettings.Controls.Add(this.groupBox9);
            this.tabSettings.Location = new System.Drawing.Point(4, 34);
            this.tabSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabSettings.Size = new System.Drawing.Size(1620, 1102);
            this.tabSettings.TabIndex = 0;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 233);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 25);
            this.label11.TabIndex = 25;
            this.label11.Text = "Password";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(245, 229);
            this.textBox8.Margin = new System.Windows.Forms.Padding(2);
            this.textBox8.Name = "textBox8";
            this.textBox8.PasswordChar = '*';
            this.textBox8.Size = new System.Drawing.Size(256, 31);
            this.textBox8.TabIndex = 24;
            this.textBox8.Text = "123";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 186);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 25);
            this.label10.TabIndex = 23;
            this.label10.Text = "Usename";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(245, 183);
            this.textBox7.Margin = new System.Windows.Forms.Padding(2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(256, 31);
            this.textBox7.TabIndex = 22;
            this.textBox7.Text = "admin";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 140);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 25);
            this.label9.TabIndex = 21;
            this.label9.Text = "Endpoint Version";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(245, 137);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(256, 31);
            this.textBox6.TabIndex = 20;
            this.textBox6.Text = "20.200.001";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 94);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "Endpoint Name";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(245, 91);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(256, 31);
            this.textBox5.TabIndex = 18;
            this.textBox5.Text = "Default";
            // 
            // lblSourceERP
            // 
            this.lblSourceERP.AutoSize = true;
            this.lblSourceERP.Location = new System.Drawing.Point(23, 51);
            this.lblSourceERP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSourceERP.Name = "lblSourceERP";
            this.lblSourceERP.Size = new System.Drawing.Size(101, 25);
            this.lblSourceERP.TabIndex = 13;
            this.lblSourceERP.Text = "Source ERP";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(255, 47);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(236, 33);
            this.comboBox3.TabIndex = 12;
            this.comboBox3.Text = "Sage MAS500";
            // 
            // lblDestinationURL
            // 
            this.lblDestinationURL.AutoSize = true;
            this.lblDestinationURL.Location = new System.Drawing.Point(13, 43);
            this.lblDestinationURL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDestinationURL.Name = "lblDestinationURL";
            this.lblDestinationURL.Size = new System.Drawing.Size(225, 25);
            this.lblDestinationURL.TabIndex = 11;
            this.lblDestinationURL.Text = "Destination Acumatica URL";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(245, 43);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(778, 33);
            this.comboBox2.TabIndex = 10;
            this.comboBox2.Text = "https://hackathon.acumatica.com/Iota";
            // 
            // lblSourceSQLConnection
            // 
            this.lblSourceSQLConnection.AutoSize = true;
            this.lblSourceSQLConnection.Location = new System.Drawing.Point(23, 99);
            this.lblSourceSQLConnection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSourceSQLConnection.Name = "lblSourceSQLConnection";
            this.lblSourceSQLConnection.Size = new System.Drawing.Size(198, 25);
            this.lblSourceSQLConnection.TabIndex = 9;
            this.lblSourceSQLConnection.Text = "Source SQL Connection";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(255, 94);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(778, 33);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.Text = "Data Source=(local);Initial Catalog=Hackathon;User ID=sa;password=";
            // 
            // tabAR
            // 
            this.tabAR.Controls.Add(this.grdExceptions);
            this.tabAR.Controls.Add(this.grdMapping);
            this.tabAR.Controls.Add(this.groupBox1);
            this.tabAR.Location = new System.Drawing.Point(4, 34);
            this.tabAR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabAR.Name = "tabAR";
            this.tabAR.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabAR.Size = new System.Drawing.Size(1620, 1102);
            this.tabAR.TabIndex = 1;
            this.tabAR.Text = "AR - Customer";
            this.tabAR.UseVisualStyleBackColor = true;
            // 
            // grdExceptions
            // 
            this.grdExceptions.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.grdExceptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdExceptions.Location = new System.Drawing.Point(20, 700);
            this.grdExceptions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grdExceptions.Name = "grdExceptions";
            this.grdExceptions.RowHeadersWidth = 62;
            this.grdExceptions.RowTemplate.Height = 25;
            this.grdExceptions.Size = new System.Drawing.Size(1579, 382);
            this.grdExceptions.TabIndex = 22;
            // 
            // grdMapping
            // 
            this.grdMapping.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.grdMapping.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMapping.Location = new System.Drawing.Point(20, 368);
            this.grdMapping.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grdMapping.Name = "grdMapping";
            this.grdMapping.RowHeadersWidth = 62;
            this.grdMapping.RowTemplate.Height = 25;
            this.grdMapping.Size = new System.Drawing.Size(1579, 322);
            this.grdMapping.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.addAcuField);
            this.groupBox1.Controls.Add(this.refreshLegacySchema);
            this.groupBox1.Controls.Add(this.cmbCustEndpointfields);
            this.groupBox1.Controls.Add(this.refreshAcuSchema);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtCustomerLastRun);
            this.groupBox1.Controls.Add(this.lblWhere1);
            this.groupBox1.Controls.Add(this.txtWhereCustomer);
            this.groupBox1.Controls.Add(this.lblSelect);
            this.groupBox1.Controls.Add(this.txtFromCustomer);
            this.groupBox1.Controls.Add(this.chkProcessCustomers);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(11, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1596, 348);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customers";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(834, 30);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(150, 31);
            this.textBox4.TabIndex = 26;
            this.textBox4.Text = "Customer";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(759, 32);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 25);
            this.label7.TabIndex = 25;
            this.label7.Text = "Entity";
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(939, 202);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(264, 42);
            this.button4.TabIndex = 24;
            this.button4.Text = "Load Mapping from Excel";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // addAcuField
            // 
            this.addAcuField.Location = new System.Drawing.Point(1401, 292);
            this.addAcuField.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addAcuField.Name = "addAcuField";
            this.addAcuField.Size = new System.Drawing.Size(71, 38);
            this.addAcuField.TabIndex = 8;
            this.addAcuField.Text = "Add";
            this.addAcuField.UseVisualStyleBackColor = true;
            this.addAcuField.Click += new System.EventHandler(this.addAcuField_Click);
            // 
            // refreshLegacySchema
            // 
            this.refreshLegacySchema.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshLegacySchema.Location = new System.Drawing.Point(939, 245);
            this.refreshLegacySchema.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.refreshLegacySchema.Name = "refreshLegacySchema";
            this.refreshLegacySchema.Size = new System.Drawing.Size(264, 42);
            this.refreshLegacySchema.TabIndex = 23;
            this.refreshLegacySchema.Text = "Refresh Legacy System Schema";
            this.refreshLegacySchema.UseVisualStyleBackColor = true;
            this.refreshLegacySchema.Click += new System.EventHandler(this.refreshLegacySchema_Click);
            // 
            // cmbCustEndpointfields
            // 
            this.cmbCustEndpointfields.FormattingEnabled = true;
            this.cmbCustEndpointfields.Location = new System.Drawing.Point(1220, 295);
            this.cmbCustEndpointfields.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCustEndpointfields.Name = "cmbCustEndpointfields";
            this.cmbCustEndpointfields.Size = new System.Drawing.Size(172, 33);
            this.cmbCustEndpointfields.TabIndex = 7;
            // 
            // refreshAcuSchema
            // 
            this.refreshAcuSchema.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshAcuSchema.Location = new System.Drawing.Point(939, 292);
            this.refreshAcuSchema.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.refreshAcuSchema.Name = "refreshAcuSchema";
            this.refreshAcuSchema.Size = new System.Drawing.Size(264, 42);
            this.refreshAcuSchema.TabIndex = 3;
            this.refreshAcuSchema.Text = "Refresh Acumatica Schema";
            this.refreshAcuSchema.UseVisualStyleBackColor = true;
            this.refreshAcuSchema.Click += new System.EventHandler(this.refreshAcuSchema_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(281, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Last Run";
            // 
            // dtCustomerLastRun
            // 
            this.dtCustomerLastRun.Location = new System.Drawing.Point(376, 32);
            this.dtCustomerLastRun.Margin = new System.Windows.Forms.Padding(2);
            this.dtCustomerLastRun.Name = "dtCustomerLastRun";
            this.dtCustomerLastRun.Size = new System.Drawing.Size(300, 31);
            this.dtCustomerLastRun.TabIndex = 5;
            // 
            // lblWhere1
            // 
            this.lblWhere1.AutoSize = true;
            this.lblWhere1.Location = new System.Drawing.Point(9, 218);
            this.lblWhere1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWhere1.Name = "lblWhere1";
            this.lblWhere1.Size = new System.Drawing.Size(63, 25);
            this.lblWhere1.TabIndex = 4;
            this.lblWhere1.Text = "Where";
            // 
            // txtWhereCustomer
            // 
            this.txtWhereCustomer.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtWhereCustomer.Location = new System.Drawing.Point(119, 210);
            this.txtWhereCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtWhereCustomer.Multiline = true;
            this.txtWhereCustomer.Name = "txtWhereCustomer";
            this.txtWhereCustomer.Size = new System.Drawing.Size(443, 114);
            this.txtWhereCustomer.TabIndex = 3;
            this.txtWhereCustomer.Text = "WHERE  a.CompanyID = \'JMS\' \r\nAND  IsNull(a.CustKey,0) <> 0 \r\nAND  a.Status = 1\r\n";
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Location = new System.Drawing.Point(8, 82);
            this.lblSelect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(107, 25);
            this.lblSelect.TabIndex = 2;
            this.lblSelect.Text = "Select/From";
            // 
            // txtFromCustomer
            // 
            this.txtFromCustomer.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFromCustomer.Location = new System.Drawing.Point(119, 75);
            this.txtFromCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFromCustomer.Multiline = true;
            this.txtFromCustomer.Name = "txtFromCustomer";
            this.txtFromCustomer.Size = new System.Drawing.Size(1466, 114);
            this.txtFromCustomer.TabIndex = 1;
            this.txtFromCustomer.Text = resources.GetString("txtFromCustomer.Text");
            // 
            // chkProcessCustomers
            // 
            this.chkProcessCustomers.AutoSize = true;
            this.chkProcessCustomers.Location = new System.Drawing.Point(9, 32);
            this.chkProcessCustomers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkProcessCustomers.Name = "chkProcessCustomers";
            this.chkProcessCustomers.Size = new System.Drawing.Size(188, 29);
            this.chkProcessCustomers.TabIndex = 0;
            this.chkProcessCustomers.Text = "Process Customers";
            this.chkProcessCustomers.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.grpCustomerAddress);
            this.tabPage7.Location = new System.Drawing.Point(4, 34);
            this.tabPage7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(1620, 1102);
            this.tabPage7.TabIndex = 10;
            this.tabPage7.Text = "AR - Address";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // grpCustomerAddress
            // 
            this.grpCustomerAddress.Controls.Add(this.label1);
            this.grpCustomerAddress.Controls.Add(this.txtWhereCustAddr);
            this.grpCustomerAddress.Controls.Add(this.label2);
            this.grpCustomerAddress.Controls.Add(this.txtSelectCustAddr);
            this.grpCustomerAddress.Controls.Add(this.checkBox1);
            this.grpCustomerAddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpCustomerAddress.Location = new System.Drawing.Point(10, 18);
            this.grpCustomerAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpCustomerAddress.Name = "grpCustomerAddress";
            this.grpCustomerAddress.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpCustomerAddress.Size = new System.Drawing.Size(1596, 348);
            this.grpCustomerAddress.TabIndex = 21;
            this.grpCustomerAddress.TabStop = false;
            this.grpCustomerAddress.Text = "Customer Addresses";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 218);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Where";
            // 
            // txtWhereCustAddr
            // 
            this.txtWhereCustAddr.Location = new System.Drawing.Point(119, 210);
            this.txtWhereCustAddr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtWhereCustAddr.Multiline = true;
            this.txtWhereCustAddr.Name = "txtWhereCustAddr";
            this.txtWhereCustAddr.Size = new System.Drawing.Size(1466, 114);
            this.txtWhereCustAddr.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select/From";
            // 
            // txtSelectCustAddr
            // 
            this.txtSelectCustAddr.Location = new System.Drawing.Point(119, 75);
            this.txtSelectCustAddr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSelectCustAddr.Multiline = true;
            this.txtSelectCustAddr.Name = "txtSelectCustAddr";
            this.txtSelectCustAddr.Size = new System.Drawing.Size(1466, 114);
            this.txtSelectCustAddr.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(9, 32);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(267, 29);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Process Customer Addresses";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tabAP
            // 
            this.tabAP.Controls.Add(this.groupBox2);
            this.tabAP.Location = new System.Drawing.Point(4, 34);
            this.tabAP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabAP.Name = "tabAP";
            this.tabAP.Size = new System.Drawing.Size(1620, 1102);
            this.tabAP.TabIndex = 2;
            this.tabAP.Text = "AP";
            this.tabAP.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(16, 22);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(1596, 348);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vendors";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 218);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Where";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(119, 210);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1466, 114);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "WHERE  a.CompanyID = \'JMS\' \r\nAND  IsNull(a.CustKey,0) <> 0 \r\nAND  a.Status = 1\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Select/From";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(119, 75);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(1466, 114);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(9, 32);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(168, 29);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "Process Vendors";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // tabGL
            // 
            this.tabGL.Controls.Add(this.groupBox3);
            this.tabGL.Location = new System.Drawing.Point(4, 34);
            this.tabGL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabGL.Name = "tabGL";
            this.tabGL.Size = new System.Drawing.Size(1620, 1102);
            this.tabGL.TabIndex = 3;
            this.tabGL.Text = "GL";
            this.tabGL.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.textBox9);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.textBox10);
            this.groupBox3.Controls.Add(this.checkBox3);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(10, 16);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(1596, 348);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "GL";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 219);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 25);
            this.label12.TabIndex = 4;
            this.label12.Text = "Where";
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox9.Location = new System.Drawing.Point(119, 210);
            this.textBox9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(1466, 114);
            this.textBox9.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 84);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 25);
            this.label13.TabIndex = 2;
            this.label13.Text = "Select/From";
            // 
            // textBox10
            // 
            this.textBox10.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox10.Location = new System.Drawing.Point(119, 75);
            this.textBox10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(1466, 114);
            this.textBox10.TabIndex = 1;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(9, 34);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(123, 29);
            this.checkBox3.TabIndex = 0;
            this.checkBox3.Text = "Process GL";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1620, 1102);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "IN";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.textBox11);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.textBox12);
            this.groupBox4.Controls.Add(this.checkBox4);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.Location = new System.Drawing.Point(6, 16);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(1596, 348);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Inventory Items";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 220);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 25);
            this.label14.TabIndex = 4;
            this.label14.Text = "Where";
            // 
            // textBox11
            // 
            this.textBox11.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox11.Location = new System.Drawing.Point(119, 210);
            this.textBox11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(1466, 114);
            this.textBox11.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 85);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(107, 25);
            this.label15.TabIndex = 2;
            this.label15.Text = "Select/From";
            // 
            // textBox12
            // 
            this.textBox12.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox12.Location = new System.Drawing.Point(119, 75);
            this.textBox12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox12.Multiline = true;
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(1466, 114);
            this.textBox12.TabIndex = 1;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(9, 35);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(227, 29);
            this.checkBox4.TabIndex = 0;
            this.checkBox4.Text = "Process Inventory Items";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1620, 1102);
            this.tabPage2.TabIndex = 5;
            this.tabPage2.Text = "SO";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.textBox13);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.textBox14);
            this.groupBox5.Controls.Add(this.checkBox5);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox5.Location = new System.Drawing.Point(10, 16);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Size = new System.Drawing.Size(1596, 348);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Sales Orders";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 221);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 25);
            this.label16.TabIndex = 4;
            this.label16.Text = "Where";
            // 
            // textBox13
            // 
            this.textBox13.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox13.Location = new System.Drawing.Point(119, 210);
            this.textBox13.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox13.Multiline = true;
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(1466, 114);
            this.textBox13.TabIndex = 3;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 86);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(107, 25);
            this.label17.TabIndex = 2;
            this.label17.Text = "Select/From";
            // 
            // textBox14
            // 
            this.textBox14.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox14.Location = new System.Drawing.Point(119, 75);
            this.textBox14.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox14.Multiline = true;
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(1466, 114);
            this.textBox14.TabIndex = 1;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(9, 36);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(202, 29);
            this.checkBox5.TabIndex = 0;
            this.checkBox5.Text = "Process Sales Orders";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox6);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1620, 1102);
            this.tabPage3.TabIndex = 6;
            this.tabPage3.Text = "PO";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.textBox15);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.textBox16);
            this.groupBox6.Controls.Add(this.checkBox6);
            this.groupBox6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox6.Location = new System.Drawing.Point(10, 16);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox6.Size = new System.Drawing.Size(1596, 348);
            this.groupBox6.TabIndex = 24;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Purchase Orders";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(9, 222);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 25);
            this.label18.TabIndex = 4;
            this.label18.Text = "Where";
            // 
            // textBox15
            // 
            this.textBox15.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox15.Location = new System.Drawing.Point(119, 210);
            this.textBox15.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox15.Multiline = true;
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(1466, 114);
            this.textBox15.TabIndex = 3;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(8, 88);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(107, 25);
            this.label19.TabIndex = 2;
            this.label19.Text = "Select/From";
            // 
            // textBox16
            // 
            this.textBox16.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox16.Location = new System.Drawing.Point(119, 75);
            this.textBox16.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox16.Multiline = true;
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(1466, 114);
            this.textBox16.TabIndex = 1;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(9, 38);
            this.checkBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(232, 29);
            this.checkBox6.TabIndex = 0;
            this.checkBox6.Text = "Process Purchase Orders";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox7);
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1620, 1102);
            this.tabPage4.TabIndex = 7;
            this.tabPage4.Text = "MF";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label20);
            this.groupBox7.Controls.Add(this.textBox17);
            this.groupBox7.Controls.Add(this.label21);
            this.groupBox7.Controls.Add(this.textBox18);
            this.groupBox7.Controls.Add(this.checkBox7);
            this.groupBox7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox7.Location = new System.Drawing.Point(4, 18);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox7.Size = new System.Drawing.Size(1596, 348);
            this.groupBox7.TabIndex = 25;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Bill of Materials";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(9, 224);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(63, 25);
            this.label20.TabIndex = 4;
            this.label20.Text = "Where";
            // 
            // textBox17
            // 
            this.textBox17.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox17.Location = new System.Drawing.Point(119, 210);
            this.textBox17.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox17.Multiline = true;
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(1466, 114);
            this.textBox17.TabIndex = 3;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(8, 89);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(107, 25);
            this.label21.TabIndex = 2;
            this.label21.Text = "Select/From";
            // 
            // textBox18
            // 
            this.textBox18.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox18.Location = new System.Drawing.Point(119, 75);
            this.textBox18.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox18.Multiline = true;
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(1466, 114);
            this.textBox18.TabIndex = 1;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(9, 39);
            this.checkBox7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(223, 29);
            this.checkBox7.TabIndex = 0;
            this.checkBox7.Text = "Process Bill of Materials";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.groupBox8);
            this.tabPage6.Location = new System.Drawing.Point(4, 34);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1620, 1102);
            this.tabPage6.TabIndex = 9;
            this.tabPage6.Text = "CRM";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label22);
            this.groupBox8.Controls.Add(this.textBox19);
            this.groupBox8.Controls.Add(this.label23);
            this.groupBox8.Controls.Add(this.textBox20);
            this.groupBox8.Controls.Add(this.checkBox8);
            this.groupBox8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox8.Location = new System.Drawing.Point(4, 5);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox8.Size = new System.Drawing.Size(1596, 348);
            this.groupBox8.TabIndex = 26;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Opportunities";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(9, 225);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(63, 25);
            this.label22.TabIndex = 4;
            this.label22.Text = "Where";
            // 
            // textBox19
            // 
            this.textBox19.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox19.Location = new System.Drawing.Point(119, 210);
            this.textBox19.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox19.Multiline = true;
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(1466, 114);
            this.textBox19.TabIndex = 3;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(8, 90);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(107, 25);
            this.label23.TabIndex = 2;
            this.label23.Text = "Select/From";
            // 
            // textBox20
            // 
            this.textBox20.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox20.Location = new System.Drawing.Point(119, 75);
            this.textBox20.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox20.Multiline = true;
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(1466, 114);
            this.textBox20.TabIndex = 1;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(9, 40);
            this.checkBox8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(202, 29);
            this.checkBox8.TabIndex = 0;
            this.checkBox8.Text = "Process Oportunities";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // btnRun
            // 
            this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRun.Location = new System.Drawing.Point(1306, 999);
            this.btnRun.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(294, 42);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "Process Data";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(984, 999);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(312, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Prepare Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.comboBox2);
            this.groupBox9.Controls.Add(this.label11);
            this.groupBox9.Controls.Add(this.lblDestinationURL);
            this.groupBox9.Controls.Add(this.textBox8);
            this.groupBox9.Controls.Add(this.textBox5);
            this.groupBox9.Controls.Add(this.label10);
            this.groupBox9.Controls.Add(this.label8);
            this.groupBox9.Controls.Add(this.textBox7);
            this.groupBox9.Controls.Add(this.textBox6);
            this.groupBox9.Controls.Add(this.label9);
            this.groupBox9.Location = new System.Drawing.Point(7, 210);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(1061, 296);
            this.groupBox9.TabIndex = 26;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Acumatica";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.comboBox3);
            this.groupBox10.Controls.Add(this.comboBox1);
            this.groupBox10.Controls.Add(this.lblSourceERP);
            this.groupBox10.Controls.Add(this.lblSourceSQLConnection);
            this.groupBox10.Location = new System.Drawing.Point(8, 16);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(1060, 158);
            this.groupBox10.TabIndex = 27;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Legacy";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 523);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(258, 34);
            this.button2.TabIndex = 28;
            this.button2.Text = "Save Configuration";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1618, 1050);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Exodus";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.tabAR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdExceptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMapping)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.grpCustomerAddress.ResumeLayout(false);
            this.grpCustomerAddress.PerformLayout();
            this.tabAP.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabGL.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private TabControl tabControl1;
    private TabPage tabSettings;
    private TabPage tabAR;
    private Label lblSourceERP;
    private ComboBox comboBox3;
    private Label lblDestinationURL;
    private ComboBox comboBox2;
    private Label lblSourceSQLConnection;
    private ComboBox comboBox1;
    private GroupBox groupBox1;
    private Label lblWhere1;
    private TextBox txtWhereCustomer;
    private Label lblSelect;
    private TextBox txtFromCustomer;
    private CheckBox chkProcessCustomers;
    private Button btnRun;
    private TabPage tabAP;
    private TabPage tabGL;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private TabPage tabPage3;
    private TabPage tabPage4;
    private TabPage tabPage6;
    private DataGridView grdMapping;
    private BindingSource bindingSource1;
    private TabPage tabPage7;
    private GroupBox grpCustomerAddress;
    private Label label1;
    private TextBox txtWhereCustAddr;
    private Label label2;
    private TextBox txtSelectCustAddr;
    private CheckBox checkBox1;
    private DataGridView grdExceptions;
    private GroupBox groupBox2;
    private Label label3;
    private TextBox textBox1;
    private Label label4;
    private TextBox textBox2;
    private CheckBox checkBox2;
    private Button button1;
    private Button refreshAcuSchema;
    private Button refreshLegacySchema;
    private Button button4;
    private Label label5;
    private DateTimePicker dtCustomerLastRun;
    private Button addAcuField;
    private ComboBox cmbCustEndpointfields;
    private Label label8;
    private TextBox textBox5;
    private Label label11;
    private TextBox textBox8;
    private Label label10;
    private TextBox textBox7;
    private Label label9;
    private TextBox textBox6;
    private TextBox textBox4;
    private Label label7;
    private GroupBox groupBox3;
    private Label label12;
    private TextBox textBox9;
    private Label label13;
    private TextBox textBox10;
    private CheckBox checkBox3;
    private GroupBox groupBox4;
    private Label label14;
    private TextBox textBox11;
    private Label label15;
    private TextBox textBox12;
    private CheckBox checkBox4;
    private GroupBox groupBox5;
    private Label label16;
    private TextBox textBox13;
    private Label label17;
    private TextBox textBox14;
    private CheckBox checkBox5;
    private GroupBox groupBox6;
    private Label label18;
    private TextBox textBox15;
    private Label label19;
    private TextBox textBox16;
    private CheckBox checkBox6;
    private GroupBox groupBox7;
    private Label label20;
    private TextBox textBox17;
    private Label label21;
    private TextBox textBox18;
    private CheckBox checkBox7;
    private GroupBox groupBox8;
    private Label label22;
    private TextBox textBox19;
    private Label label23;
    private TextBox textBox20;
    private CheckBox checkBox8;
    private Button button2;
    private GroupBox groupBox10;
    private GroupBox groupBox9;
}