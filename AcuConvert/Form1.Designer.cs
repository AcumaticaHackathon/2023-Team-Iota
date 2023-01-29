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
            this.lblConnectorConnectString = new System.Windows.Forms.Label();
            this.cboConnectorConnectString = new System.Windows.Forms.ComboBox();
            this.lblSourceERP = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.lblDestinationURL = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblSourceSQLConnection = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabAR = new System.Windows.Forms.TabPage();
            this.grdExceptions = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.tabControl1.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.tabAR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdExceptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.tabSettings.Controls.Add(this.lblConnectorConnectString);
            this.tabSettings.Controls.Add(this.cboConnectorConnectString);
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
            // lblConnectorConnectString
            // 
            this.lblConnectorConnectString.AutoSize = true;
            this.lblConnectorConnectString.Location = new System.Drawing.Point(14, 77);
            this.lblConnectorConnectString.Name = "lblConnectorConnectString";
            this.lblConnectorConnectString.Size = new System.Drawing.Size(145, 15);
            this.lblConnectorConnectString.TabIndex = 17;
            this.lblConnectorConnectString.Text = "Connector Connect String";
            // 
            // cboConnectorConnectString
            // 
            this.cboConnectorConnectString.FormattingEnabled = true;
            this.cboConnectorConnectString.Location = new System.Drawing.Point(177, 74);
            this.cboConnectorConnectString.Name = "cboConnectorConnectString";
            this.cboConnectorConnectString.Size = new System.Drawing.Size(546, 23);
            this.cboConnectorConnectString.TabIndex = 16;
            this.cboConnectorConnectString.Text = "Data Source=(local);Initial Catalog=AcuConvert;User ID=sa;password=";
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
            this.lblDestinationURL.Location = new System.Drawing.Point(14, 110);
            this.lblDestinationURL.Name = "lblDestinationURL";
            this.lblDestinationURL.Size = new System.Drawing.Size(151, 15);
            this.lblDestinationURL.TabIndex = 11;
            this.lblDestinationURL.Text = "Destination Acumatica URL";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(177, 107);
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
            this.tabAR.Controls.Add(this.dataGridView1);
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
            this.grdExceptions.RowTemplate.Height = 25;
            this.grdExceptions.Size = new System.Drawing.Size(1105, 230);
            this.grdExceptions.TabIndex = 22;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 221);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1105, 193);
            this.dataGridView1.TabIndex = 21;
            // 
            // groupBox1
            // 
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
            this.txtWhereCustomer.Size = new System.Drawing.Size(1028, 70);
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
            this.btnRun.Location = new System.Drawing.Point(1015, 691);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(121, 25);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "Run ...";
            this.btnRun.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 723);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
    private Label lblConnectorConnectString;
    private ComboBox cboConnectorConnectString;
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
    private DataGridView dataGridView1;
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
}