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
            this.label1 = new System.Windows.Forms.Label();
            this.listCommands = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbLibrary = new System.Windows.Forms.ComboBox();
            this.txtCommandHelpDetails = new System.Windows.Forms.RichTextBox();
            this.cmbCommandType = new System.Windows.Forms.ComboBox();
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
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCommandType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGetCommandHelp = new System.Windows.Forms.Button();
            this.grpDetails.SuspendLayout();
            this.grpList.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "All Commands";
            // 
            // listCommands
            // 
            this.listCommands.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listCommands.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader3});
            this.listCommands.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCommands.FullRowSelect = true;
            this.listCommands.GridLines = true;
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
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 100;
            // 
            // cmbLibrary
            // 
            this.cmbLibrary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbLibrary.FormattingEnabled = true;
            this.cmbLibrary.Location = new System.Drawing.Point(540, 13);
            this.cmbLibrary.Name = "cmbLibrary";
            this.cmbLibrary.Size = new System.Drawing.Size(264, 24);
            this.cmbLibrary.TabIndex = 3;
            // 
            // txtCommandHelpDetails
            // 
            this.txtCommandHelpDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCommandHelpDetails.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommandHelpDetails.Location = new System.Drawing.Point(11, 21);
            this.txtCommandHelpDetails.Name = "txtCommandHelpDetails";
            this.txtCommandHelpDetails.Size = new System.Drawing.Size(1443, 390);
            this.txtCommandHelpDetails.TabIndex = 5;
            this.txtCommandHelpDetails.Text = "";
            // 
            // cmbCommandType
            // 
            this.cmbCommandType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCommandType.FormattingEnabled = true;
            this.cmbCommandType.Location = new System.Drawing.Point(938, 13);
            this.cmbCommandType.Name = "cmbCommandType";
            this.cmbCommandType.Size = new System.Drawing.Size(264, 24);
            this.cmbCommandType.TabIndex = 3;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.Blue;
            this.lblInfo.Location = new System.Drawing.Point(675, 459);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(33, 18);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "Info";
            // 
            // btnSampleExample
            // 
            this.btnSampleExample.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSampleExample.Enabled = false;
            this.btnSampleExample.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSampleExample.ForeColor = System.Drawing.Color.Navy;
            this.btnSampleExample.Location = new System.Drawing.Point(1473, 25);
            this.btnSampleExample.Name = "btnSampleExample";
            this.btnSampleExample.Size = new System.Drawing.Size(207, 36);
            this.btnSampleExample.TabIndex = 9;
            this.btnSampleExample.Text = "Sample Example";
            this.btnSampleExample.UseVisualStyleBackColor = true;
            this.btnSampleExample.Click += new System.EventHandler(this.btnSampleExample_Click);
            // 
            // btnDetailedExample
            // 
            this.btnDetailedExample.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetailedExample.Enabled = false;
            this.btnDetailedExample.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetailedExample.ForeColor = System.Drawing.Color.Navy;
            this.btnDetailedExample.Location = new System.Drawing.Point(1473, 84);
            this.btnDetailedExample.Name = "btnDetailedExample";
            this.btnDetailedExample.Size = new System.Drawing.Size(207, 36);
            this.btnDetailedExample.TabIndex = 9;
            this.btnDetailedExample.Text = "Detailed Example";
            this.btnDetailedExample.UseVisualStyleBackColor = true;
            this.btnDetailedExample.Click += new System.EventHandler(this.btnDetailedExample_Click);
            // 
            // btnTechnicalInformation
            // 
            this.btnTechnicalInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTechnicalInformation.Enabled = false;
            this.btnTechnicalInformation.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTechnicalInformation.ForeColor = System.Drawing.Color.Navy;
            this.btnTechnicalInformation.Location = new System.Drawing.Point(1473, 143);
            this.btnTechnicalInformation.Name = "btnTechnicalInformation";
            this.btnTechnicalInformation.Size = new System.Drawing.Size(207, 36);
            this.btnTechnicalInformation.TabIndex = 9;
            this.btnTechnicalInformation.Text = "Technical Information";
            this.btnTechnicalInformation.UseVisualStyleBackColor = true;
            this.btnTechnicalInformation.Click += new System.EventHandler(this.btnTechnicalInformation_Click);
            // 
            // btnOnlineHelp
            // 
            this.btnOnlineHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOnlineHelp.Enabled = false;
            this.btnOnlineHelp.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOnlineHelp.ForeColor = System.Drawing.Color.Navy;
            this.btnOnlineHelp.Location = new System.Drawing.Point(1473, 202);
            this.btnOnlineHelp.Name = "btnOnlineHelp";
            this.btnOnlineHelp.Size = new System.Drawing.Size(207, 36);
            this.btnOnlineHelp.TabIndex = 9;
            this.btnOnlineHelp.Text = "Online Help...";
            this.btnOnlineHelp.UseVisualStyleBackColor = true;
            this.btnOnlineHelp.Click += new System.EventHandler(this.btnOnlineHelp_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(483, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Source";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(854, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "Commands";
            // 
            // lblPowerShellVersion
            // 
            this.lblPowerShellVersion.AutoSize = true;
            this.lblPowerShellVersion.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPowerShellVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(219)))));
            this.lblPowerShellVersion.Location = new System.Drawing.Point(17, 13);
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
            this.grpDetails.Size = new System.Drawing.Size(1701, 430);
            this.grpDetails.TabIndex = 10;
            this.grpDetails.TabStop = false;
            this.grpDetails.Visible = false;
            // 
            // btnFullView
            // 
            this.btnFullView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFullView.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFullView.ForeColor = System.Drawing.Color.Navy;
            this.btnFullView.Location = new System.Drawing.Point(1473, 375);
            this.btnFullView.Name = "btnFullView";
            this.btnFullView.Size = new System.Drawing.Size(207, 36);
            this.btnFullView.TabIndex = 9;
            this.btnFullView.Text = "< Full View >";
            this.btnFullView.UseVisualStyleBackColor = true;
            this.btnFullView.Click += new System.EventHandler(this.btnFullView_Click);
            // 
            // grpList
            // 
            this.grpList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpList.Controls.Add(this.txtCommand);
            this.grpList.Controls.Add(this.txtVersion);
            this.grpList.Controls.Add(this.label2);
            this.grpList.Controls.Add(this.txtSource);
            this.grpList.Controls.Add(this.label3);
            this.grpList.Controls.Add(this.txtCommandType);
            this.grpList.Controls.Add(this.label4);
            this.grpList.Controls.Add(this.label5);
            this.grpList.Controls.Add(this.btnGetCommandHelp);
            this.grpList.Controls.Add(this.label1);
            this.grpList.Controls.Add(this.label6);
            this.grpList.Controls.Add(this.label7);
            this.grpList.Controls.Add(this.cmbCommandType);
            this.grpList.Controls.Add(this.listCommands);
            this.grpList.Controls.Add(this.cmbLibrary);
            this.grpList.Location = new System.Drawing.Point(9, 40);
            this.grpList.Name = "grpList";
            this.grpList.Size = new System.Drawing.Size(1701, 415);
            this.grpList.TabIndex = 11;
            this.grpList.TabStop = false;
            this.grpList.Visible = false;
            // 
            // txtCommand
            // 
            this.txtCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCommand.BackColor = System.Drawing.SystemColors.Control;
            this.txtCommand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCommand.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommand.ForeColor = System.Drawing.Color.Navy;
            this.txtCommand.Location = new System.Drawing.Point(1230, 136);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.ReadOnly = true;
            this.txtCommand.Size = new System.Drawing.Size(450, 27);
            this.txtCommand.TabIndex = 13;
            // 
            // txtVersion
            // 
            this.txtVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVersion.BackColor = System.Drawing.SystemColors.Control;
            this.txtVersion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVersion.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVersion.ForeColor = System.Drawing.Color.Navy;
            this.txtVersion.Location = new System.Drawing.Point(1230, 316);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.ReadOnly = true;
            this.txtVersion.Size = new System.Drawing.Size(239, 29);
            this.txtVersion.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.label2.Location = new System.Drawing.Point(1230, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Command";
            // 
            // txtSource
            // 
            this.txtSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSource.BackColor = System.Drawing.SystemColors.Control;
            this.txtSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSource.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSource.ForeColor = System.Drawing.Color.Navy;
            this.txtSource.Location = new System.Drawing.Point(1230, 257);
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
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.label3.Location = new System.Drawing.Point(1230, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Type";
            // 
            // txtCommandType
            // 
            this.txtCommandType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCommandType.BackColor = System.Drawing.SystemColors.Control;
            this.txtCommandType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCommandType.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommandType.ForeColor = System.Drawing.Color.Navy;
            this.txtCommandType.Location = new System.Drawing.Point(1230, 198);
            this.txtCommandType.Name = "txtCommandType";
            this.txtCommandType.ReadOnly = true;
            this.txtCommandType.Size = new System.Drawing.Size(450, 29);
            this.txtCommandType.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.label4.Location = new System.Drawing.Point(1230, 296);
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
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.label5.Location = new System.Drawing.Point(1230, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Source";
            // 
            // btnGetCommandHelp
            // 
            this.btnGetCommandHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetCommandHelp.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetCommandHelp.ForeColor = System.Drawing.Color.Navy;
            this.btnGetCommandHelp.Location = new System.Drawing.Point(1230, 60);
            this.btnGetCommandHelp.Name = "btnGetCommandHelp";
            this.btnGetCommandHelp.Size = new System.Drawing.Size(450, 36);
            this.btnGetCommandHelp.TabIndex = 8;
            this.btnGetCommandHelp.Text = "Get Details";
            this.btnGetCommandHelp.UseVisualStyleBackColor = true;
            this.btnGetCommandHelp.Click += new System.EventHandler(this.btnGetCommandHelp_Click);
            // 
            // frmPowerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1718, 918);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listCommands;
        private System.Windows.Forms.ComboBox cmbLibrary;
        private System.Windows.Forms.RichTextBox txtCommandHelpDetails;
        private System.Windows.Forms.ComboBox cmbCommandType;
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
    }
}

