using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerUI
{
    public partial class frmPowerUI : Form
    {
        private string powerShellPath = "WindowsPowerShell";
        private string powerShellExe = "powershell.exe";

        private string GetHelp_Command = "Get-Help";

        private bool isPowerShellAvailable = false;
        private FileInfo powerShellInfo;

        private bool hasSampleExample = false;
        private bool hasDetailedExample = false;
        private bool hasTechnicalDetails = false;
        private bool hasOnlineHelp = false;

        Size commandHelpSize, fullViewButtonSize;
        Point commandHelpLocation, fullViewButtonLocation;
        bool fullViewMode = false;

        public frmPowerUI()
        {
            InitializeComponent();
        }

        private void frmPowerUI_Load(object sender, EventArgs e)
        {
            txtCommand.BorderStyle = txtCommandType.BorderStyle = txtSource.BorderStyle = txtVersion.BorderStyle = BorderStyle.None;
            
            CheckForPowershell();
            if (isPowerShellAvailable == false)
            {
                MessageBox.Show("PowerShell is not installed. Please, install from here - www.msdn.microsoft.com/powershell", "PowerUI");
                return;
            }

            lblPowerShellVersion.Text = "PowerShell => " + powerShellInfo.FullName;
            lblPowerShellVersion.Refresh();
          
            Thread.Sleep(100);
            ShowUpdate("Getting All Commands...");
            GetAllPowerShellCommands();

            ShowUpdate("Loading All Commands...");
            LoadAllCommands();

            grpDetails.Visible = true;
            grpList.Visible = true;

            ShowUpdate("All Commands loaded.");
        }

        private void ShowUpdate(string message)
        {
            lblInfo.Text = message;
            lblInfo.Left = (this.Width / 2) - (lblInfo.Width / 2);
            lblInfo.Refresh();
        }

        private void LoadAllCommands()
        {
            string[] lines = File.ReadAllLines("AllCommands.txt");
            ParseCommands(lines);
        }

        private void ParseCommands(string[] input)
        {
            int percentage = 0;
            int totalCommands = input.Length;

            string[] command;
            string[] separator = new string[1];
            separator[0] = " ";
            bool commandStarted = false;

            listCommands.BackColor = Color.White;
            listCommands.Enabled = false;
            int itemNo = 0;

            foreach (string line in input)
            {
                command = line.Split(separator, StringSplitOptions.RemoveEmptyEntries);

                if (command.Length > 0)
                {
                    if (commandStarted)
                    {
                        ListViewItem item = new ListViewItem(command[0]);
                        if (itemNo++ % 2 == 0)
                            item.ForeColor = Color.DimGray;
                        else
                            item.ForeColor = Color.Black;

                        listCommands.Items.Add(item);

                        switch (command.Length)
                        {

                            case 1:
                                item.Text = command[0];
                                item.SubItems.Add("");
                                item.SubItems.Add("");
                                item.SubItems.Add("");
                                break;
                            case 2:
                                item.Text = command[1];
                                item.SubItems.Add(command[0]);
                                item.SubItems.Add("");
                                item.SubItems.Add("");
                                break;
                            case 3:
                                item.Text = command[1];
                                item.SubItems.Add(command[0]);
                                item.SubItems.Add(command[2]);
                                item.SubItems.Add("");
                                break;
                            case 4:
                                item.Text = command[1];
                                item.SubItems.Add(command[0]);
                                item.SubItems.Add(command[3]);
                                item.SubItems.Add(command[2]);
                                break;
                            default:
                                break;
                        }

                        ////for (int index = 1; index < command.Length; index++)
                        ////{
                        ////    item.SubItems.Add(command[index]);
                        ////}
                        //listCommands.TopItem = item;
                        //listCommands.EnsureVisible(listCommands.Items.Count - 1);
                        listCommands.EnsureVisible(0);
                        //listCommands.Refresh();
                    }
                    else
                    {
                        if (command[0].Contains("-"))
                        {
                            commandStarted = true;
                        }
                    }
                }
            }

            listCommands.EnsureVisible(0);
            listCommands.Enabled = true;
        }

        private void CheckForPowershell()
        {
            string systemPath = Environment.GetFolderPath(Environment.SpecialFolder.System);

            string powerShellFolder = Path.Combine(systemPath, powerShellPath);
            if (Directory.Exists(powerShellFolder))
            {
                string powerShellExePath = Path.Combine(powerShellFolder, powerShellExe);
                if (File.Exists(powerShellExePath))
                {
                    isPowerShellAvailable = true;
                }
                else
                {
                    string[] directories = Directory.GetDirectories(powerShellFolder);
                    foreach (string directory in directories)
                    {
                        powerShellFolder = directory;
                        powerShellExePath = Path.Combine(powerShellFolder, powerShellExe);

                        if (File.Exists(powerShellExePath))
                        {
                            isPowerShellAvailable = true;
                            powerShellInfo = new FileInfo(powerShellExePath);
                            return;
                        }
                    }
                }
            }
        }

        private void GetAllPowerShellCommands()
        {
            if (File.Exists("AllCommands.txt"))
            {
                return;
            }

            GetAllCommands();
        }

        private void GetAllCommands()
        {
            string commands = "Get-Command";
            string args = ">> AllCommands.txt";
            RunShellCommand(commands, args);
        }

        private void RunShellCommand(string command, string args = "")
        {
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = powerShellInfo.FullName;
            info.Arguments = command + " " + args;
            info.WindowStyle = ProcessWindowStyle.Hidden;

            Process process = new Process();
            process.StartInfo = info;
            process.Exited += Process_Exited;

            process.Start();

            while (process.HasExited != true) ;
        }

        private void Process_Exited(object sender, EventArgs e)
        {
            ShowUpdate("");
        }

        private void btnGetCommandHelp_Click(object sender, EventArgs e)
        {
            btnSampleExample.Enabled = false;
            btnDetailedExample.Enabled = false;
            btnTechnicalInformation.Enabled = false;
            btnOnlineHelp.Enabled = false;

            if (txtCommand.Text == "")
                ShowUpdate("Getting PowerShell help details");
            else
                ShowUpdate("Getting details for $ " + txtCommand.Text);

            File.WriteAllText("CommandHelp.txt", "");
            txtCommandHelpDetails.Text = "";
            GetCommandHelp(txtCommand.Text + " >> CommandHelp.txt");
            txtCommandHelpDetails.Text = File.ReadAllText("CommandHelp.txt");

            txtCommandHelpDetails.Text = ParseCommandHelp(txtCommandHelpDetails.Text);
            ShowUpdate("");

            EnableControls();

            grpDetails.Text = " " + txtCommand.Text + " ( " + txtCommandType.Text + " ) >";
        }

        private string ParseCommandHelp(string helpText)
        {
            hasOnlineHelp = false;
            hasTechnicalDetails = false;
            hasDetailedExample = false;
            hasSampleExample = false;

            int remarksIndex = helpText.IndexOf("REMARKS");
            if (remarksIndex > 0)
            {
                if (helpText.IndexOf("-examples", remarksIndex + 1) > 0)
                {
                    hasSampleExample = true;
                }

                if (helpText.IndexOf("-detailed", remarksIndex + 1) > 0)
                {
                    hasDetailedExample = true;
                }

                if (helpText.IndexOf("-full", remarksIndex + 1) > 0)
                {
                    hasTechnicalDetails = true;
                }

                if (helpText.IndexOf("-online", remarksIndex + 1) > 0)
                {
                    hasOnlineHelp = true;
                }

                return helpText.Substring(0, remarksIndex);
            }

            return helpText;
        }

        private void GetCommandHelp(string args)
        {
            RunShellCommand(GetHelp_Command, args);
        }

        private void listCommands_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listCommands.SelectedItems.Count == 0)
            {
                return;
            }

            ListViewItem item = listCommands.SelectedItems[0];

            txtCommand.Text = item.SubItems[0].Text;
            txtCommandType.Text = item.SubItems[1].Text;

            //if (item.SubItems.Count > 1)
            //{
            txtSource.Text = item.SubItems[2].Text;
            //}
            //if (item.SubItems.Count > 2)
            //{
            txtVersion.Text = item.SubItems[3].Text;
            //}

        }

        private void btnSampleExample_Click(object sender, EventArgs e)
        {
            DisableControls();

            ShowUpdate("Getting " + ((Button)sender).Text + " details");

            txtCommandHelpDetails.Text = "";
            txtCommandHelpDetails.Refresh();

            GetCommandHelp(txtCommand.Text + " -examples >> CommandHelpExample.txt");
            txtCommandHelpDetails.Text = File.ReadAllText("CommandHelpExample.txt");

            int remarksIndex = txtCommandHelpDetails.Text.IndexOf("REMARKS");
            if (remarksIndex > 0)
            {
                txtCommandHelpDetails.Text = txtCommandHelpDetails.Text.Substring(0, remarksIndex);
            }

            EnableControls();
        }

        private void DisableControls()
        {
            btnGetCommandHelp.Enabled = false;
            btnSampleExample.Enabled = false;
            btnDetailedExample.Enabled = false;
            btnTechnicalInformation.Enabled = false;
            btnOnlineHelp.Enabled = false;
        }

        private void EnableControls()
        {
            btnGetCommandHelp.Enabled = true;
            btnSampleExample.Enabled = hasSampleExample;
            btnDetailedExample.Enabled = hasDetailedExample;
            btnTechnicalInformation.Enabled = hasTechnicalDetails;
            btnOnlineHelp.Enabled = hasOnlineHelp;
        }

        private void btnDetailedExample_Click(object sender, EventArgs e)
        {
            DisableControls();

            ShowUpdate("Getting " + ((Button)sender).Text + " details");

            txtCommandHelpDetails.Text = "";
            txtCommandHelpDetails.Refresh();

            GetCommandHelp(txtCommand.Text + " -detailed >> CommandHelpDetailed.txt");
            txtCommandHelpDetails.Text = File.ReadAllText("CommandHelpDetailed.txt");

            int remarksIndex = txtCommandHelpDetails.Text.IndexOf("REMARKS");
            if (remarksIndex > 0)
            {
                txtCommandHelpDetails.Text = txtCommandHelpDetails.Text.Substring(0, remarksIndex);
            }

            EnableControls();

        }

        private void btnTechnicalInformation_Click(object sender, EventArgs e)
        {
            DisableControls();

            ShowUpdate("Getting " + ((Button)sender).Text + " details");

            txtCommandHelpDetails.Text = "";
            txtCommandHelpDetails.Refresh();

            GetCommandHelp(txtCommand.Text + " -full >> CommandHelpTechnical.txt");
            txtCommandHelpDetails.Text = File.ReadAllText("CommandHelpTechnical.txt");

            int remarksIndex = txtCommandHelpDetails.Text.IndexOf("REMARKS");
            if (remarksIndex > 0)
            {
                txtCommandHelpDetails.Text = txtCommandHelpDetails.Text.Substring(0, remarksIndex);
            }

            EnableControls();
        }

        private void btnOnlineHelp_Click(object sender, EventArgs e)
        {
            DisableControls();

            ShowUpdate("Getting " + ((Button)sender).Text + " details");

            GetCommandHelp(txtCommand.Text + " -online");

            EnableControls();

        }

        private void FrmPowerUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Cleanup
            foreach (string f in Directory.GetFiles(".", "*.txt"))
            {
                File.Delete(f);
            }
        }

        private void btnFullView_Click(object sender, EventArgs e)
        {
            if (fullViewMode)
            {
                ResetFullView();
            }
            else
            {
                SetFullView();
            }
        }

        private void FrmPowerUI_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    if (fullViewMode)
                    {
                        ResetFullView();
                        e.Handled = true;
                    }
                    break;
                case Keys.F12:
                    if (btnFullView.Enabled)
                    {
                        SetFullView();
                        e.Handled = true;
                    }
                    break;
            }
        }

        private void SetFullView()
        {
            commandHelpSize = txtCommandHelpDetails.Size;
            commandHelpLocation = txtCommandHelpDetails.Location;
            fullViewButtonSize = btnFullView.Size;
            fullViewButtonLocation = btnFullView.Location;

            txtCommandHelpDetails.Parent = this;

            txtCommandHelpDetails.Left = 08;
            txtCommandHelpDetails.Top = lblPowerShellVersion.Top + lblPowerShellVersion.Height + 5;
            txtCommandHelpDetails.Width = this.Width - 30;
            txtCommandHelpDetails.Height = this.Height - 80;
            txtCommandHelpDetails.BringToFront();

            btnFullView.Parent = this;
            btnFullView.Top = txtCommandHelpDetails.Top - btnFullView.Height;
            btnFullView.Text = "Close Full View (ESC)";
            btnFullView.BackColor = Color.Black;
            btnFullView.ForeColor = Color.White;
            btnFullView.BringToFront();

            fullViewMode = true;
        }

        private void ResetFullView()
        {
            txtCommandHelpDetails.Parent = grpDetails;
            btnFullView.Parent = grpDetails;

            txtCommandHelpDetails.Size = commandHelpSize;
            txtCommandHelpDetails.Location = commandHelpLocation;

            btnFullView.Size = fullViewButtonSize;
            btnFullView.Location = fullViewButtonLocation;
            btnFullView.ForeColor = Color.Navy;
            btnFullView.UseVisualStyleBackColor = true;
            btnFullView.Text = "< Full View (F12) >";

            fullViewMode = false;
        }
    }
}
