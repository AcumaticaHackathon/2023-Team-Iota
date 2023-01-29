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
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.btnRun = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
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
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(0, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1139, 684);
            this.tabControl1.TabIndex = 0;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.label7);
            this.tabSettings.Controls.Add(this.textBox4);
            this.tabSettings.Controls.Add(this.label6);
            this.tabSettings.Controls.Add(this.textBox3);
            this.tabSettings.Controls.Add(this.lblSourceERP);
            this.tabSettings.Controls.Add(this.comboBox3);
            this.tabSettings.Controls.Add(this.lblDestinationURL);
            this.tabSettings.Controls.Add(this.comboBox2);
            this.tabSettings.Controls.Add(this.lblSourceSQLConnection);
            this.tabSettings.Controls.Add(this.comboBox1);
            this.tabSettings.Location = new System.Drawing.Point(4, 24);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(1131, 656);
            this.tabSettings.TabIndex = 0;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Destination Acumatica URL";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(176, 140);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(181, 23);
            this.textBox4.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Destination Acumatica URL";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(176, 106);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(181, 23);
            this.textBox3.TabIndex = 14;
            // 
            // lblSourceERP
            // 
            this.lblSourceERP.AutoSize = true;
            this.lblSourceERP.Location = new System.Drawing.Point(14, 19);
            this.lblSourceERP.Name = "lblSourceERP";
            this.lblSourceERP.Size = new System.Drawing.Size(66, 15);
            this.lblSourceERP.TabIndex = 13;
            this.lblSourceERP.Text = "Source ERP";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(177, 16);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(167, 23);
            this.comboBox3.TabIndex = 12;
            this.comboBox3.Text = "Sage MAS500";
            // 
            // lblDestinationURL
            // 
            this.lblDestinationURL.AutoSize = true;
            this.lblDestinationURL.Location = new System.Drawing.Point(14, 77);
            this.lblDestinationURL.Name = "lblDestinationURL";
            this.lblDestinationURL.Size = new System.Drawing.Size(151, 15);
            this.lblDestinationURL.TabIndex = 11;
            this.lblDestinationURL.Text = "Destination Acumatica URL";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(177, 77);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(546, 23);
            this.comboBox2.TabIndex = 10;
            this.comboBox2.Text = "https://hackathon.acumatica.com/Iota";
            // 
            // lblSourceSQLConnection
            // 
            this.lblSourceSQLConnection.AutoSize = true;
            this.lblSourceSQLConnection.Location = new System.Drawing.Point(14, 48);
            this.lblSourceSQLConnection.Name = "lblSourceSQLConnection";
            this.lblSourceSQLConnection.Size = new System.Drawing.Size(132, 15);
            this.lblSourceSQLConnection.TabIndex = 9;
            this.lblSourceSQLConnection.Text = "Source SQL Connection";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(177, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(546, 23);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.Text = "Data Source=(local);Initial Catalog=Hackathon;User ID=sa;password=";
            // 
            // tabAR
            // 
            this.tabAR.Controls.Add(this.grdExceptions);
            this.tabAR.Controls.Add(this.grdMapping);
            this.tabAR.Controls.Add(this.groupBox1);
            this.tabAR.Location = new System.Drawing.Point(4, 24);
            this.tabAR.Name = "tabAR";
            this.tabAR.Padding = new System.Windows.Forms.Padding(3);
            this.tabAR.Size = new System.Drawing.Size(1131, 656);
            this.tabAR.TabIndex = 1;
            this.tabAR.Text = "AR - Customer";
            this.tabAR.UseVisualStyleBackColor = true;
            // 
            // grdExceptions
            // 
            this.grdExceptions.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.grdExceptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdExceptions.Location = new System.Drawing.Point(14, 420);
            this.grdExceptions.Name = "grdExceptions";
            this.grdExceptions.RowHeadersWidth = 62;
            this.grdExceptions.RowTemplate.Height = 25;
            this.grdExceptions.Size = new System.Drawing.Size(1105, 230);
            this.grdExceptions.TabIndex = 22;
            // 
            // grdMapping
            // 
            this.grdMapping.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.grdMapping.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMapping.Location = new System.Drawing.Point(14, 221);
            this.grdMapping.Name = "grdMapping";
            this.grdMapping.RowHeadersWidth = 62;
            this.grdMapping.RowTemplate.Height = 25;
            this.grdMapping.Size = new System.Drawing.Size(1105, 193);
            this.grdMapping.TabIndex = 21;
            // 
            // groupBox1
            // 
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
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1117, 209);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customers";
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(657, 121);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(185, 25);
            this.button4.TabIndex = 24;
            this.button4.Text = "Load Mapping from Excel";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // addAcuField
            // 
            this.addAcuField.Location = new System.Drawing.Point(981, 176);
            this.addAcuField.Name = "addAcuField";
            this.addAcuField.Size = new System.Drawing.Size(50, 23);
            this.addAcuField.TabIndex = 8;
            this.addAcuField.Text = "Add";
            this.addAcuField.UseVisualStyleBackColor = true;
            this.addAcuField.Click += new System.EventHandler(this.addAcuField_Click);
            // 
            // refreshLegacySchema
            // 
            this.refreshLegacySchema.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshLegacySchema.Location = new System.Drawing.Point(657, 147);
            this.refreshLegacySchema.Name = "refreshLegacySchema";
            this.refreshLegacySchema.Size = new System.Drawing.Size(185, 25);
            this.refreshLegacySchema.TabIndex = 23;
            this.refreshLegacySchema.Text = "Refresh Legacy System Schema";
            this.refreshLegacySchema.UseVisualStyleBackColor = true;
            this.refreshLegacySchema.Click += new System.EventHandler(this.refreshLegacySchema_Click);
            // 
            // cmbCustEndpointfields
            // 
            this.cmbCustEndpointfields.FormattingEnabled = true;
            this.cmbCustEndpointfields.Location = new System.Drawing.Point(854, 177);
            this.cmbCustEndpointfields.Name = "cmbCustEndpointfields";
            this.cmbCustEndpointfields.Size = new System.Drawing.Size(121, 23);
            this.cmbCustEndpointfields.TabIndex = 7;
            // 
            // refreshAcuSchema
            // 
            this.refreshAcuSchema.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshAcuSchema.Location = new System.Drawing.Point(657, 176);
            this.refreshAcuSchema.Name = "refreshAcuSchema";
            this.refreshAcuSchema.Size = new System.Drawing.Size(185, 25);
            this.refreshAcuSchema.TabIndex = 3;
            this.refreshAcuSchema.Text = "Refresh Acumatica Schema";
            this.refreshAcuSchema.UseVisualStyleBackColor = true;
            this.refreshAcuSchema.Click += new System.EventHandler(this.refreshAcuSchema_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(197, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Last Run";
            // 
            // dtCustomerLastRun
            // 
            this.dtCustomerLastRun.Location = new System.Drawing.Point(263, 20);
            this.dtCustomerLastRun.Margin = new System.Windows.Forms.Padding(2);
            this.dtCustomerLastRun.Name = "dtCustomerLastRun";
            this.dtCustomerLastRun.Size = new System.Drawing.Size(211, 23);
            this.dtCustomerLastRun.TabIndex = 5;
            // 
            // lblWhere1
            // 
            this.lblWhere1.AutoSize = true;
            this.lblWhere1.Location = new System.Drawing.Point(6, 130);
            this.lblWhere1.Name = "lblWhere1";
            this.lblWhere1.Size = new System.Drawing.Size(41, 15);
            this.lblWhere1.TabIndex = 4;
            this.lblWhere1.Text = "Where";
            // 
            // txtWhereCustomer
            // 
            this.txtWhereCustomer.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtWhereCustomer.Location = new System.Drawing.Point(83, 126);
            this.txtWhereCustomer.Multiline = true;
            this.txtWhereCustomer.Name = "txtWhereCustomer";
            this.txtWhereCustomer.Size = new System.Drawing.Size(311, 70);
            this.txtWhereCustomer.TabIndex = 3;
            this.txtWhereCustomer.Text = "WHERE  a.CompanyID = \'JMS\' \r\nAND  IsNull(a.CustKey,0) <> 0 \r\nAND  a.Status = 1\r\n";
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Location = new System.Drawing.Point(6, 49);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(71, 15);
            this.lblSelect.TabIndex = 2;
            this.lblSelect.Text = "Select/From";
            // 
            // txtFromCustomer
            // 
            this.txtFromCustomer.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFromCustomer.Location = new System.Drawing.Point(83, 45);
            this.txtFromCustomer.Multiline = true;
            this.txtFromCustomer.Name = "txtFromCustomer";
            this.txtFromCustomer.Size = new System.Drawing.Size(1028, 70);
            this.txtFromCustomer.TabIndex = 1;
            this.txtFromCustomer.Text = resources.GetString("txtFromCustomer.Text");
            // 
            // chkProcessCustomers
            // 
            this.chkProcessCustomers.AutoSize = true;
            this.chkProcessCustomers.Location = new System.Drawing.Point(6, 20);
            this.chkProcessCustomers.Name = "chkProcessCustomers";
            this.chkProcessCustomers.Size = new System.Drawing.Size(126, 19);
            this.chkProcessCustomers.TabIndex = 0;
            this.chkProcessCustomers.Text = "Process Customers";
            this.chkProcessCustomers.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.grpCustomerAddress);
            this.tabPage7.Location = new System.Drawing.Point(4, 24);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(1131, 656);
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
            this.grpCustomerAddress.Location = new System.Drawing.Point(7, 11);
            this.grpCustomerAddress.Name = "grpCustomerAddress";
            this.grpCustomerAddress.Size = new System.Drawing.Size(1117, 209);
            this.grpCustomerAddress.TabIndex = 21;
            this.grpCustomerAddress.TabStop = false;
            this.grpCustomerAddress.Text = "Customer Addresses";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Where";
            // 
            // txtWhereCustAddr
            // 
            this.txtWhereCustAddr.Location = new System.Drawing.Point(83, 126);
            this.txtWhereCustAddr.Multiline = true;
            this.txtWhereCustAddr.Name = "txtWhereCustAddr";
            this.txtWhereCustAddr.Size = new System.Drawing.Size(1028, 70);
            this.txtWhereCustAddr.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select/From";
            // 
            // txtSelectCustAddr
            // 
            this.txtSelectCustAddr.Location = new System.Drawing.Point(83, 45);
            this.txtSelectCustAddr.Multiline = true;
            this.txtSelectCustAddr.Name = "txtSelectCustAddr";
            this.txtSelectCustAddr.Size = new System.Drawing.Size(1028, 70);
            this.txtSelectCustAddr.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(177, 19);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Process Customer Addresses";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tabAP
            // 
            this.tabAP.Controls.Add(this.groupBox2);
            this.tabAP.Location = new System.Drawing.Point(4, 24);
            this.tabAP.Name = "tabAP";
            this.tabAP.Size = new System.Drawing.Size(1131, 656);
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
            this.groupBox2.Location = new System.Drawing.Point(11, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1117, 209);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vendors";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Where";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(83, 126);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1028, 70);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "WHERE  a.CompanyID = \'JMS\' \r\nAND  IsNull(a.CustKey,0) <> 0 \r\nAND  a.Status = 1\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Select/From";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(83, 45);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(1028, 70);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 20);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(111, 19);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "Process Vendors";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // tabGL
            // 
            this.tabGL.Location = new System.Drawing.Point(4, 24);
            this.tabGL.Name = "tabGL";
            this.tabGL.Size = new System.Drawing.Size(1131, 656);
            this.tabGL.TabIndex = 3;
            this.tabGL.Text = "GL";
            this.tabGL.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1131, 656);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "IN";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1131, 656);
            this.tabPage2.TabIndex = 5;
            this.tabPage2.Text = "SO";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1131, 656);
            this.tabPage3.TabIndex = 6;
            this.tabPage3.Text = "PO";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1131, 656);
            this.tabPage4.TabIndex = 7;
            this.tabPage4.Text = "MF";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1131, 656);
            this.tabPage5.TabIndex = 8;
            this.tabPage5.Text = "CR";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 24);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1131, 656);
            this.tabPage6.TabIndex = 9;
            this.tabPage6.Text = "CRM";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // btnRun
            // 
            this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRun.Location = new System.Drawing.Point(914, 691);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(206, 25);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "Process Data";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(689, 691);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "Prepare Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 722);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "AccuConvert";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
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
    private TabPage tabPage5;
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
    private Label label7;
    private TextBox textBox4;
    private Label label6;
    private TextBox textBox3;
    private Button addAcuField;
    private ComboBox cmbCustEndpointfields;
}