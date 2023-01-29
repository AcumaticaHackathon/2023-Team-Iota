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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblDestinationInstance = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.lblSourceERP = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.lblDestinationURL = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblSourceSQLConnection = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1139, 719);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblDestinationInstance);
            this.tabPage1.Controls.Add(this.comboBox4);
            this.tabPage1.Controls.Add(this.lblSourceERP);
            this.tabPage1.Controls.Add(this.comboBox3);
            this.tabPage1.Controls.Add(this.lblDestinationURL);
            this.tabPage1.Controls.Add(this.comboBox2);
            this.tabPage1.Controls.Add(this.lblSourceSQLConnection);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1131, 691);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1131, 691);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "AR";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // lblDestinationInstance
            // 
            this.lblDestinationInstance.AutoSize = true;
            this.lblDestinationInstance.Location = new System.Drawing.Point(14, 106);
            this.lblDestinationInstance.Name = "lblDestinationInstance";
            this.lblDestinationInstance.Size = new System.Drawing.Size(114, 15);
            this.lblDestinationInstance.TabIndex = 15;
            this.lblDestinationInstance.Text = "Destination Instance";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(177, 103);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(132, 23);
            this.comboBox4.TabIndex = 14;
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
            this.comboBox2.Location = new System.Drawing.Point(177, 74);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(546, 23);
            this.comboBox2.TabIndex = 10;
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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 723);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "AccuConvert";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private TabControl tabControl1;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private Label lblDestinationInstance;
    private ComboBox comboBox4;
    private Label lblSourceERP;
    private ComboBox comboBox3;
    private Label lblDestinationURL;
    private ComboBox comboBox2;
    private Label lblSourceSQLConnection;
    private ComboBox comboBox1;
}