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
        private bool isPowerShellAvailable = false;
        private FileInfo powerShellInfo;

        public frmPowerUI()
        {
            InitializeComponent();
        }

        private void frmPowerUI_Load(object sender, EventArgs e)
        {
            CheckForPowershell();
            if (isPowerShellAvailable == false)
            {
                MessageBox.Show("PowerShell is not installed. Please, install from here - www.msdn.microsoft.com/powershell", "PowerUI");
                return;
            }

            lblPowerShellVersion.Text = "PowerShell --> " + powerShellInfo.FullName;

            lblInfo.Text = "Getting All Commands...";
            lblInfo.Refresh();
            Thread.Sleep(200);
            GetAllPowerShellCommands();

            lblInfo.Text = "All Commands got.";
            lblInfo.Refresh();

            lblInfo.Text = "Loading All Commands...";
            lblInfo.Refresh();

            LoadAllCommands();

            lblInfo.Text = "All Commands loaded.";
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

            foreach (string line in input)
            {
                command = line.Split(separator, StringSplitOptions.RemoveEmptyEntries);

                if (command.Length > 0)
                {
                    if (commandStarted)
                    {
                        ListViewItem item = new ListViewItem(command[0]);
                        listCommands.Items.Add(item);
                        for (int index = 1; index < command.Length; index++)
                        {
                            item.SubItems.Add(command[index]);
                        }
                        listCommands.TopItem = item;
                        //listCommands.EnsureVisible(listCommands.Items.Count - 1);
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
            lblInfo.Text = "All Commands Loaded.";
            lblInfo.Refresh();
        }

        private void btnGetCommandHelp_Click(object sender, EventArgs e)
        {
            btnSampleExample.Enabled = false;
            btnDetailedExample.Enabled = false;
            btnTechnicalInformation.Enabled = false;
            btnOnlineHelp.Enabled = false;

            lblInfo.Text = "Getting details for - " + txtCommand.Text;

            File.WriteAllText("CommandHelp.txt", "");
            txtCommandHelpDetails.Text = "";
            GetCommandHelp(txtCommand.Text + " >> CommandHelp.txt");
            txtCommandHelpDetails.Text = File.ReadAllText("CommandHelp.txt");

            txtCommandHelpDetails.Text = ParseCommandHelp(txtCommandHelpDetails.Text);
            lblInfo.Text = "";
        }

        private string ParseCommandHelp(string helpText)
        {
            int remarksIndex = helpText.IndexOf("REMARKS");
            if (remarksIndex > 0)
            {
                if (helpText.IndexOf("-examples", remarksIndex + 1) > 0)
                {
                    btnSampleExample.Enabled = true;
                }

                if (helpText.IndexOf("-detailed", remarksIndex + 1) > 0)
                {
                    btnDetailedExample.Enabled = true;
                }

                if (helpText.IndexOf("-full", remarksIndex + 1) > 0)
                {
                    btnTechnicalInformation.Enabled = true;
                }

                if (helpText.IndexOf("-online", remarksIndex + 1) > 0)
                {
                    btnOnlineHelp.Enabled = true;
                }

                return helpText.Substring(0, remarksIndex);
            }

            return helpText;
        }

        private void GetCommandHelp(string args)
        {
            string command = "Get-Help";

            RunShellCommand(command, args);
        }

        private void listCommands_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listCommands.SelectedItems.Count == 0)
            {
                return;
            }

            ListViewItem item = listCommands.SelectedItems[0];

            txtCommandType.Text = item.SubItems[0].Text;
            txtCommand.Text = item.SubItems[1].Text;

            if (item.SubItems.Count > 1)
            {
                txtVersion.Text = item.SubItems[2].Text;
            }
            if (item.SubItems.Count > 2)
            {
                txtSource.Text = item.SubItems[3].Text;
            }
        }

        private void btnSampleExample_Click(object sender, EventArgs e)
        {
            GetCommandHelp(txtCommand.Text + " -examples >> CommandHelpExample.txt");
            txtCommandHelpDetails.Text = File.ReadAllText("CommandHelpExample.txt");

            int remarksIndex = txtCommandHelpDetails.Text.IndexOf("REMARKS");
            if (remarksIndex > 0)
            {
                txtCommandHelpDetails.Text = txtCommandHelpDetails.Text.Substring(0, remarksIndex);
            }
        }

        private void btnDetailedExample_Click(object sender, EventArgs e)
        {
            GetCommandHelp(txtCommand.Text + " -detailed >> CommandHelpDetailed.txt");
            txtCommandHelpDetails.Text = File.ReadAllText("CommandHelpDetailed.txt");

            int remarksIndex = txtCommandHelpDetails.Text.IndexOf("REMARKS");
            if (remarksIndex > 0)
            {
                txtCommandHelpDetails.Text = txtCommandHelpDetails.Text.Substring(0, remarksIndex);
            }
        }

        private void btnTechnicalInformation_Click(object sender, EventArgs e)
        {
            GetCommandHelp(txtCommand.Text + " -full >> CommandHelpTechnical.txt");
            txtCommandHelpDetails.Text = File.ReadAllText("CommandHelpTechnical.txt");

            int remarksIndex = txtCommandHelpDetails.Text.IndexOf("REMARKS");
            if (remarksIndex > 0)
            {
                txtCommandHelpDetails.Text = txtCommandHelpDetails.Text.Substring(0, remarksIndex);
            }
        }

        private void btnOnlineHelp_Click(object sender, EventArgs e)
        {
            GetCommandHelp(txtCommand.Text + " -online");
        }
    }
}
