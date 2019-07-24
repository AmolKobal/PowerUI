﻿namespace PowerUI
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
            this.btnGetCommandHelp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listCommands = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbLibrary = new System.Windows.Forms.ComboBox();
            this.txtCommandHelpDetails = new System.Windows.Forms.RichTextBox();
            this.cmbCommandType = new System.Windows.Forms.ComboBox();
            this.lblPowerShellVersion = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCommandType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.grpCommand = new System.Windows.Forms.GroupBox();
            this.btnSampleExample = new System.Windows.Forms.Button();
            this.btnDetailedExample = new System.Windows.Forms.Button();
            this.btnTechnicalInformation = new System.Windows.Forms.Button();
            this.btnOnlineHelp = new System.Windows.Forms.Button();
            this.grpCommand.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetCommandHelp
            // 
            this.btnGetCommandHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetCommandHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetCommandHelp.Location = new System.Drawing.Point(22, 21);
            this.btnGetCommandHelp.Name = "btnGetCommandHelp";
            this.btnGetCommandHelp.Size = new System.Drawing.Size(481, 36);
            this.btnGetCommandHelp.TabIndex = 0;
            this.btnGetCommandHelp.Text = "Get Additional Details";
            this.btnGetCommandHelp.UseVisualStyleBackColor = true;
            this.btnGetCommandHelp.Click += new System.EventHandler(this.btnGetCommandHelp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Commands";
            // 
            // listCommands
            // 
            this.listCommands.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listCommands.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listCommands.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCommands.FullRowSelect = true;
            this.listCommands.GridLines = true;
            this.listCommands.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listCommands.Location = new System.Drawing.Point(26, 66);
            this.listCommands.MultiSelect = false;
            this.listCommands.Name = "listCommands";
            this.listCommands.Size = new System.Drawing.Size(1154, 357);
            this.listCommands.TabIndex = 2;
            this.listCommands.UseCompatibleStateImageBehavior = false;
            this.listCommands.View = System.Windows.Forms.View.Details;
            this.listCommands.SelectedIndexChanged += new System.EventHandler(this.listCommands_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Type";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Command";
            this.columnHeader2.Width = 500;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Version";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Source";
            this.columnHeader4.Width = 400;
            // 
            // cmbLibrary
            // 
            this.cmbLibrary.FormattingEnabled = true;
            this.cmbLibrary.Location = new System.Drawing.Point(502, 30);
            this.cmbLibrary.Name = "cmbLibrary";
            this.cmbLibrary.Size = new System.Drawing.Size(275, 24);
            this.cmbLibrary.TabIndex = 3;
            // 
            // txtCommandHelpDetails
            // 
            this.txtCommandHelpDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCommandHelpDetails.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommandHelpDetails.Location = new System.Drawing.Point(26, 473);
            this.txtCommandHelpDetails.Name = "txtCommandHelpDetails";
            this.txtCommandHelpDetails.Size = new System.Drawing.Size(1154, 372);
            this.txtCommandHelpDetails.TabIndex = 5;
            this.txtCommandHelpDetails.Text = "";
            // 
            // cmbCommandType
            // 
            this.cmbCommandType.FormattingEnabled = true;
            this.cmbCommandType.Location = new System.Drawing.Point(842, 30);
            this.cmbCommandType.Name = "cmbCommandType";
            this.cmbCommandType.Size = new System.Drawing.Size(275, 24);
            this.cmbCommandType.TabIndex = 3;
            // 
            // lblPowerShellVersion
            // 
            this.lblPowerShellVersion.AutoSize = true;
            this.lblPowerShellVersion.Location = new System.Drawing.Point(23, 863);
            this.lblPowerShellVersion.Name = "lblPowerShellVersion";
            this.lblPowerShellVersion.Size = new System.Drawing.Size(78, 17);
            this.lblPowerShellVersion.TabIndex = 1;
            this.lblPowerShellVersion.Text = "PowerShell";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.Blue;
            this.lblInfo.Location = new System.Drawing.Point(23, 441);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(13, 18);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Command";
            // 
            // txtCommand
            // 
            this.txtCommand.BackColor = System.Drawing.Color.White;
            this.txtCommand.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommand.Location = new System.Drawing.Point(19, 102);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.ReadOnly = true;
            this.txtCommand.Size = new System.Drawing.Size(484, 27);
            this.txtCommand.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Type";
            // 
            // txtCommandType
            // 
            this.txtCommandType.BackColor = System.Drawing.Color.White;
            this.txtCommandType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommandType.Location = new System.Drawing.Point(19, 172);
            this.txtCommandType.Name = "txtCommandType";
            this.txtCommandType.ReadOnly = true;
            this.txtCommandType.Size = new System.Drawing.Size(484, 24);
            this.txtCommandType.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Version";
            // 
            // txtVersion
            // 
            this.txtVersion.BackColor = System.Drawing.Color.White;
            this.txtVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVersion.Location = new System.Drawing.Point(19, 246);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.ReadOnly = true;
            this.txtVersion.Size = new System.Drawing.Size(239, 24);
            this.txtVersion.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Source";
            // 
            // txtSource
            // 
            this.txtSource.BackColor = System.Drawing.Color.White;
            this.txtSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSource.Location = new System.Drawing.Point(19, 313);
            this.txtSource.Name = "txtSource";
            this.txtSource.ReadOnly = true;
            this.txtSource.Size = new System.Drawing.Size(484, 24);
            this.txtSource.TabIndex = 7;
            // 
            // grpCommand
            // 
            this.grpCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCommand.Controls.Add(this.txtCommand);
            this.grpCommand.Controls.Add(this.txtVersion);
            this.grpCommand.Controls.Add(this.label2);
            this.grpCommand.Controls.Add(this.txtSource);
            this.grpCommand.Controls.Add(this.label3);
            this.grpCommand.Controls.Add(this.txtCommandType);
            this.grpCommand.Controls.Add(this.label4);
            this.grpCommand.Controls.Add(this.label5);
            this.grpCommand.Controls.Add(this.btnGetCommandHelp);
            this.grpCommand.Location = new System.Drawing.Point(1186, 66);
            this.grpCommand.Name = "grpCommand";
            this.grpCommand.Size = new System.Drawing.Size(520, 357);
            this.grpCommand.TabIndex = 8;
            this.grpCommand.TabStop = false;
            // 
            // btnSampleExample
            // 
            this.btnSampleExample.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSampleExample.Location = new System.Drawing.Point(1208, 492);
            this.btnSampleExample.Name = "btnSampleExample";
            this.btnSampleExample.Size = new System.Drawing.Size(481, 36);
            this.btnSampleExample.TabIndex = 9;
            this.btnSampleExample.Text = "Sample Example";
            this.btnSampleExample.UseVisualStyleBackColor = true;
            this.btnSampleExample.Click += new System.EventHandler(this.btnSampleExample_Click);
            // 
            // btnDetailedExample
            // 
            this.btnDetailedExample.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetailedExample.Location = new System.Drawing.Point(1208, 549);
            this.btnDetailedExample.Name = "btnDetailedExample";
            this.btnDetailedExample.Size = new System.Drawing.Size(481, 36);
            this.btnDetailedExample.TabIndex = 9;
            this.btnDetailedExample.Text = "Detailed Example";
            this.btnDetailedExample.UseVisualStyleBackColor = true;
            this.btnDetailedExample.Click += new System.EventHandler(this.btnDetailedExample_Click);
            // 
            // btnTechnicalInformation
            // 
            this.btnTechnicalInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTechnicalInformation.Location = new System.Drawing.Point(1208, 615);
            this.btnTechnicalInformation.Name = "btnTechnicalInformation";
            this.btnTechnicalInformation.Size = new System.Drawing.Size(481, 36);
            this.btnTechnicalInformation.TabIndex = 9;
            this.btnTechnicalInformation.Text = "Technical Information";
            this.btnTechnicalInformation.UseVisualStyleBackColor = true;
            this.btnTechnicalInformation.Click += new System.EventHandler(this.btnTechnicalInformation_Click);
            // 
            // btnOnlineHelp
            // 
            this.btnOnlineHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOnlineHelp.Location = new System.Drawing.Point(1208, 670);
            this.btnOnlineHelp.Name = "btnOnlineHelp";
            this.btnOnlineHelp.Size = new System.Drawing.Size(481, 36);
            this.btnOnlineHelp.TabIndex = 9;
            this.btnOnlineHelp.Text = "Online Help";
            this.btnOnlineHelp.UseVisualStyleBackColor = true;
            this.btnOnlineHelp.Click += new System.EventHandler(this.btnOnlineHelp_Click);
            // 
            // frmPowerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1718, 931);
            this.Controls.Add(this.btnOnlineHelp);
            this.Controls.Add(this.btnTechnicalInformation);
            this.Controls.Add(this.btnDetailedExample);
            this.Controls.Add(this.btnSampleExample);
            this.Controls.Add(this.grpCommand);
            this.Controls.Add(this.txtCommandHelpDetails);
            this.Controls.Add(this.cmbCommandType);
            this.Controls.Add(this.cmbLibrary);
            this.Controls.Add(this.listCommands);
            this.Controls.Add(this.lblPowerShellVersion);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.label1);
            this.Name = "frmPowerUI";
            this.Text = "Powershell UI Utility";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPowerUI_Load);
            this.grpCommand.ResumeLayout(false);
            this.grpCommand.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetCommandHelp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listCommands;
        private System.Windows.Forms.ComboBox cmbLibrary;
        private System.Windows.Forms.RichTextBox txtCommandHelpDetails;
        private System.Windows.Forms.ComboBox cmbCommandType;
        private System.Windows.Forms.Label lblPowerShellVersion;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCommandType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVersion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.GroupBox grpCommand;
        private System.Windows.Forms.Button btnSampleExample;
        private System.Windows.Forms.Button btnDetailedExample;
        private System.Windows.Forms.Button btnTechnicalInformation;
        private System.Windows.Forms.Button btnOnlineHelp;
    }
}

