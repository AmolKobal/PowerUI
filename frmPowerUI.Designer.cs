namespace PowerUI
{
    partial class frmPowerUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAllCommands = new System.Windows.Forms.Label();
            this.listCommands = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.txtCommandHelpDetails = new System.Windows.Forms.RichTextBox();
            this.cmbSource = new System.Windows.Forms.ComboBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnSampleExample = new System.Windows.Forms.Button();
            this.btnDetailedExample = new System.Windows.Forms.Button();
            this.btnTechnicalInformation = new System.Windows.Forms.Button();
            this.btnOnlineHelp = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPowerShellVersion = new System.Windows.Forms.Label();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.btnFullView = new System.Windows.Forms.Button();
            this.grpList = new System.Windows.Forms.GroupBox();
            this.txtSearchContent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCommandType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGetCommandHelp = new System.Windows.Forms.Button();
            this.btnTheme = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpDetails.SuspendLayout();
            this.grpList.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAllCommands
            // 
            this.lblAllCommands.AutoSize = true;
            this.lblAllCommands.Font = new System.Drawing.Font("Calibri", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllCommands.ForeColor = System.Drawing.Color.Magenta;
            this.lblAllCommands.Location = new System.Drawing.Point(10, 18);
            this.lblAllCommands.Name = "lblAllCommands";
            this.lblAllCommands.Size = new System.Drawing.Size(97, 18);
            this.lblAllCommands.TabIndex = 1;
            this.lblAllCommands.Text = "All Commands";
            // 
            // listCommands
            // 
            this.listCommands.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listCommands.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listCommands.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listCommands.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader3});
            this.listCommands.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCommands.FullRowSelect = true;
            this.listCommands.HideSelection = false;
            this.listCommands.Location = new System.Drawing.Point(6, 43);
            this.listCommands.MultiSelect = false;
            this.listCommands.Name = "listCommands";
            this.listCommands.Size = new System.Drawing.Size(1196, 361);
            this.listCommands.TabIndex = 2;
            this.listCommands.UseCompatibleStateImageBehavior = false;
            this.listCommands.View = System.Windows.Forms.View.Details;
            this.listCommands.SelectedIndexChanged += new System.EventHandler(this.listCommands_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Command";
            this.columnHeader2.Width = 500;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Type";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Source";
            this.columnHeader4.Width = 400;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Version";
            this.columnHeader3.Width = 80;
            // 
            // cmbType
            // 
            this.cmbType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbType.BackColor = System.Drawing.Color.Black;
            this.cmbType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbType.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.ForeColor = System.Drawing.Color.Magenta;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(124, 56);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(322, 29);
            this.cmbType.TabIndex = 3;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.CmbType_SelectedIndexChanged);
            // 
            // txtCommandHelpDetails
            // 
            this.txtCommandHelpDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCommandHelpDetails.BackColor = System.Drawing.Color.Black;
            this.txtCommandHelpDetails.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommandHelpDetails.ForeColor = System.Drawing.Color.White;
            this.txtCommandHelpDetails.Location = new System.Drawing.Point(11, 21);
            this.txtCommandHelpDetails.Name = "txtCommandHelpDetails";
            this.txtCommandHelpDetails.ReadOnly = true;
            this.txtCommandHelpDetails.Size = new System.Drawing.Size(1415, 402);
            this.txtCommandHelpDetails.TabIndex = 5;
            this.txtCommandHelpDetails.Text = "";
            // 
            // cmbSource
            // 
            this.cmbSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSource.BackColor = System.Drawing.Color.Black;
            this.cmbSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSource.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSource.ForeColor = System.Drawing.Color.Magenta;
            this.cmbSource.FormattingEnabled = true;
            this.cmbSource.Location = new System.Drawing.Point(124, 21);
            this.cmbSource.Name = "cmbSource";
            this.cmbSource.Size = new System.Drawing.Size(322, 29);
            this.cmbSource.TabIndex = 3;
            this.cmbSource.SelectedIndexChanged += new System.EventHandler(this.CmbSource_SelectedIndexChanged);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.Lime;
            this.lblInfo.Location = new System.Drawing.Point(675, 457);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(38, 21);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "Info";
            // 
            // btnSampleExample
            // 
            this.btnSampleExample.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSampleExample.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnSampleExample.Enabled = false;
            this.btnSampleExample.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSampleExample.FlatAppearance.BorderSize = 2;
            this.btnSampleExample.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSampleExample.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSampleExample.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnSampleExample.Location = new System.Drawing.Point(1445, 25);
            this.btnSampleExample.Name = "btnSampleExample";
            this.btnSampleExample.Size = new System.Drawing.Size(207, 36);
            this.btnSampleExample.TabIndex = 9;
            this.btnSampleExample.Text = "Sample Example";
            this.btnSampleExample.UseVisualStyleBackColor = false;
            this.btnSampleExample.Click += new System.EventHandler(this.btnSampleExample_Click);
            // 
            // btnDetailedExample
            // 
            this.btnDetailedExample.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetailedExample.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnDetailedExample.Enabled = false;
            this.btnDetailedExample.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDetailedExample.FlatAppearance.BorderSize = 2;
            this.btnDetailedExample.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetailedExample.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetailedExample.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnDetailedExample.Location = new System.Drawing.Point(1445, 84);
            this.btnDetailedExample.Name = "btnDetailedExample";
            this.btnDetailedExample.Size = new System.Drawing.Size(207, 36);
            this.btnDetailedExample.TabIndex = 9;
            this.btnDetailedExample.Text = "Detailed Example";
            this.btnDetailedExample.UseVisualStyleBackColor = false;
            this.btnDetailedExample.Click += new System.EventHandler(this.btnDetailedExample_Click);
            // 
            // btnTechnicalInformation
            // 
            this.btnTechnicalInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTechnicalInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnTechnicalInformation.Enabled = false;
            this.btnTechnicalInformation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTechnicalInformation.FlatAppearance.BorderSize = 2;
            this.btnTechnicalInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTechnicalInformation.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTechnicalInformation.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnTechnicalInformation.Location = new System.Drawing.Point(1445, 143);
            this.btnTechnicalInformation.Name = "btnTechnicalInformation";
            this.btnTechnicalInformation.Size = new System.Drawing.Size(207, 36);
            this.btnTechnicalInformation.TabIndex = 9;
            this.btnTechnicalInformation.Text = "Technical Information";
            this.btnTechnicalInformation.UseVisualStyleBackColor = false;
            this.btnTechnicalInformation.Click += new System.EventHandler(this.btnTechnicalInformation_Click);
            // 
            // btnOnlineHelp
            // 
            this.btnOnlineHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOnlineHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnOnlineHelp.Enabled = false;
            this.btnOnlineHelp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOnlineHelp.FlatAppearance.BorderSize = 2;
            this.btnOnlineHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnlineHelp.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOnlineHelp.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnOnlineHelp.Location = new System.Drawing.Point(1445, 202);
            this.btnOnlineHelp.Name = "btnOnlineHelp";
            this.btnOnlineHelp.Size = new System.Drawing.Size(207, 36);
            this.btnOnlineHelp.TabIndex = 9;
            this.btnOnlineHelp.Text = "Online Help...";
            this.btnOnlineHelp.UseVisualStyleBackColor = false;
            this.btnOnlineHelp.Click += new System.EventHandler(this.btnOnlineHelp_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Magenta;
            this.label6.Location = new System.Drawing.Point(77, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Type";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Magenta;
            this.label7.Location = new System.Drawing.Point(65, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "Source";
            // 
            // lblPowerShellVersion
            // 
            this.lblPowerShellVersion.AutoSize = true;
            this.lblPowerShellVersion.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPowerShellVersion.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblPowerShellVersion.Location = new System.Drawing.Point(12, 13);
            this.lblPowerShellVersion.Name = "lblPowerShellVersion";
            this.lblPowerShellVersion.Size = new System.Drawing.Size(99, 20);
            this.lblPowerShellVersion.TabIndex = 1;
            this.lblPowerShellVersion.Text = "Powershell";
            // 
            // grpDetails
            // 
            this.grpDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDetails.Controls.Add(this.btnSampleExample);
            this.grpDetails.Controls.Add(this.btnFullView);
            this.grpDetails.Controls.Add(this.btnOnlineHelp);
            this.grpDetails.Controls.Add(this.txtCommandHelpDetails);
            this.grpDetails.Controls.Add(this.btnDetailedExample);
            this.grpDetails.Controls.Add(this.btnTechnicalInformation);
            this.grpDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpDetails.Font = new System.Drawing.Font("Consolas", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.grpDetails.Location = new System.Drawing.Point(9, 476);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(1673, 438);
            this.grpDetails.TabIndex = 10;
            this.grpDetails.TabStop = false;
            this.grpDetails.Visible = false;
            // 
            // btnFullView
            // 
            this.btnFullView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFullView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnFullView.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFullView.FlatAppearance.BorderSize = 2;
            this.btnFullView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFullView.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFullView.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnFullView.Location = new System.Drawing.Point(1445, 387);
            this.btnFullView.Name = "btnFullView";
            this.btnFullView.Size = new System.Drawing.Size(207, 36);
            this.btnFullView.TabIndex = 9;
            this.btnFullView.Text = "< Full View >";
            this.btnFullView.UseVisualStyleBackColor = false;
            this.btnFullView.Visible = false;
            this.btnFullView.Click += new System.EventHandler(this.btnFullView_Click);
            // 
            // grpList
            // 
            this.grpList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpList.Controls.Add(this.groupBox1);
            this.grpList.Controls.Add(this.txtSearchContent);
            this.grpList.Controls.Add(this.label1);
            this.grpList.Controls.Add(this.txtCommand);
            this.grpList.Controls.Add(this.txtVersion);
            this.grpList.Controls.Add(this.label2);
            this.grpList.Controls.Add(this.txtSource);
            this.grpList.Controls.Add(this.label3);
            this.grpList.Controls.Add(this.txtCommandType);
            this.grpList.Controls.Add(this.label4);
            this.grpList.Controls.Add(this.label5);
            this.grpList.Controls.Add(this.btnGetCommandHelp);
            this.grpList.Controls.Add(this.lblAllCommands);
            this.grpList.Controls.Add(this.listCommands);
            this.grpList.Location = new System.Drawing.Point(9, 38);
            this.grpList.Name = "grpList";
            this.grpList.Size = new System.Drawing.Size(1673, 417);
            this.grpList.TabIndex = 11;
            this.grpList.TabStop = false;
            this.grpList.Visible = false;
            // 
            // txtSearchContent
            // 
            this.txtSearchContent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchContent.BackColor = System.Drawing.Color.Black;
            this.txtSearchContent.Font = new System.Drawing.Font("Consolas", 10.2F);
            this.txtSearchContent.ForeColor = System.Drawing.Color.White;
            this.txtSearchContent.Location = new System.Drawing.Point(1330, 43);
            this.txtSearchContent.Name = "txtSearchContent";
            this.txtSearchContent.Size = new System.Drawing.Size(322, 27);
            this.txtSearchContent.TabIndex = 18;
            this.txtSearchContent.TextChanged += new System.EventHandler(this.TxtSearchContent_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Magenta;
            this.label1.Location = new System.Drawing.Point(1206, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Search Commands";
            // 
            // txtCommand
            // 
            this.txtCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCommand.BackColor = System.Drawing.Color.Black;
            this.txtCommand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCommand.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommand.ForeColor = System.Drawing.Color.Yellow;
            this.txtCommand.Location = new System.Drawing.Point(1210, 268);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.ReadOnly = true;
            this.txtCommand.Size = new System.Drawing.Size(450, 29);
            this.txtCommand.TabIndex = 13;
            // 
            // txtVersion
            // 
            this.txtVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVersion.BackColor = System.Drawing.Color.Black;
            this.txtVersion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVersion.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVersion.ForeColor = System.Drawing.Color.Yellow;
            this.txtVersion.Location = new System.Drawing.Point(1467, 375);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.ReadOnly = true;
            this.txtVersion.Size = new System.Drawing.Size(193, 29);
            this.txtVersion.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1208, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Command";
            // 
            // txtSource
            // 
            this.txtSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSource.BackColor = System.Drawing.Color.Black;
            this.txtSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSource.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSource.ForeColor = System.Drawing.Color.Yellow;
            this.txtSource.Location = new System.Drawing.Point(1210, 321);
            this.txtSource.Name = "txtSource";
            this.txtSource.ReadOnly = true;
            this.txtSource.Size = new System.Drawing.Size(450, 29);
            this.txtSource.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1213, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Type";
            // 
            // txtCommandType
            // 
            this.txtCommandType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCommandType.BackColor = System.Drawing.Color.Black;
            this.txtCommandType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCommandType.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommandType.ForeColor = System.Drawing.Color.Yellow;
            this.txtCommandType.Location = new System.Drawing.Point(1215, 376);
            this.txtCommandType.Name = "txtCommandType";
            this.txtCommandType.ReadOnly = true;
            this.txtCommandType.Size = new System.Drawing.Size(241, 29);
            this.txtCommandType.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1465, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Version";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1208, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Source";
            // 
            // btnGetCommandHelp
            // 
            this.btnGetCommandHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetCommandHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnGetCommandHelp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGetCommandHelp.FlatAppearance.BorderSize = 2;
            this.btnGetCommandHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetCommandHelp.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetCommandHelp.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnGetCommandHelp.Location = new System.Drawing.Point(1210, 195);
            this.btnGetCommandHelp.Name = "btnGetCommandHelp";
            this.btnGetCommandHelp.Size = new System.Drawing.Size(450, 36);
            this.btnGetCommandHelp.TabIndex = 8;
            this.btnGetCommandHelp.Text = "Get Details";
            this.btnGetCommandHelp.UseVisualStyleBackColor = false;
            this.btnGetCommandHelp.Click += new System.EventHandler(this.btnGetCommandHelp_Click);
            // 
            // btnTheme
            // 
            this.btnTheme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTheme.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTheme.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTheme.ForeColor = System.Drawing.Color.Cyan;
            this.btnTheme.Location = new System.Drawing.Point(1445, 8);
            this.btnTheme.Name = "btnTheme";
            this.btnTheme.Size = new System.Drawing.Size(207, 29);
            this.btnTheme.TabIndex = 12;
            this.btnTheme.Text = "Theme (Black)";
            this.btnTheme.UseVisualStyleBackColor = false;
            this.btnTheme.Click += new System.EventHandler(this.BtnTheme_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cmbSource);
            this.groupBox1.Controls.Add(this.cmbType);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Lime;
            this.groupBox1.Location = new System.Drawing.Point(1206, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 103);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // frmPowerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1694, 926);
            this.Controls.Add(this.btnTheme);
            this.Controls.Add(this.grpList);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblPowerShellVersion);
            this.KeyPreview = true;
            this.Name = "frmPowerUI";
            this.Text = "Powershell UI Utility";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPowerUI_FormClosing);
            this.Load += new System.EventHandler(this.frmPowerUI_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPowerUI_KeyDown);
            this.grpDetails.ResumeLayout(false);
            this.grpList.ResumeLayout(false);
            this.grpList.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAllCommands;
        private System.Windows.Forms.ListView listCommands;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.RichTextBox txtCommandHelpDetails;
        private System.Windows.Forms.ComboBox cmbSource;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnSampleExample;
        private System.Windows.Forms.Button btnDetailedExample;
        private System.Windows.Forms.Button btnTechnicalInformation;
        private System.Windows.Forms.Button btnOnlineHelp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPowerShellVersion;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.GroupBox grpList;
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.TextBox txtVersion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCommandType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGetCommandHelp;
        private System.Windows.Forms.Button btnFullView;
        private System.Windows.Forms.Button btnTheme;
        private System.Windows.Forms.TextBox txtSearchContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

