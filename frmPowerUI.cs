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
        private string powerShellFolder = "WindowsPowerShell";
        private string powerShellExe = "powershell.exe";

        private string GetHelp_Command = "Get-Help";

        private bool isPowerShellAvailable = false;
        private FileInfo powerShellInfo;

        int TimeOutValue = 1000;
        int elapsedTime = 0;
        bool isTimeOut;
        private System.Timers.Timer timeout = new System.Timers.Timer(100);
        private Color alternateRowColor = Color.FromArgb(248, 248, 248);

        private bool hasSampleExample = false;
        private bool hasDetailedExample = false;
        private bool hasTechnicalDetails = false;
        private bool hasOnlineHelp = false;

        Size commandHelpSize, fullViewButtonSize;
        Point commandHelpLocation, fullViewButtonLocation;
        bool fullViewMode = false;

        string command;

        IList<string> objAllTypes = new List<string>();
        IList<string> objAllSources = new List<string>();

        IList<Command> allCommands = new List<Command>();

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

            objAllTypes.Add("(All)");
            objAllSources.Add("(All)");

            lblPowerShellVersion.Text = "PowerShell => " + powerShellInfo.FullName;
            lblPowerShellVersion.Refresh();

            Thread.Sleep(100);
            ShowUpdate("Getting All Commands...");
            GetAllPowerShellCommands();

            ShowUpdate("Loading All Commands...");

            string[] lines = File.ReadAllLines("AllCommands.txt");
            ParseCommands(lines);
            cmbType.DataSource = objAllTypes;
            cmbSource.DataSource = objAllSources;

            LoadCommands("(All)", "(All)");

            grpList.Visible = true;

            ShowUpdate("All Commands loaded.");
        }

        private void ShowUpdate(string message)
        {
            lblInfo.Text = message;
            lblInfo.Left = (this.Width / 2) - (lblInfo.Width / 2);
            lblInfo.Refresh();
        }

        private void LoadCommands(string type, string source)
        {
            int itemNo = 0;

            IEnumerable<Command> commands = null;

            ShowUpdate($"Loading Commands Type: {type}, Source {source}");

            listCommands.Items.Clear();
            listCommands.Enabled = false;

            if ("(All)" == type && "(All)" == source)
            {
                commands = allCommands;
            }
            else if ("(All)" == type && "(All)" != source)
            {
                commands = from cmd in allCommands where cmd.Source == source select cmd;
            }
            else if ("(All)" != type && "(All)" == source)
            {
                commands = from cmd in allCommands where cmd.Type == type select cmd;
            }
            else if ("(All)" != type && "(All)" != source)
            {
                commands = from cmd in allCommands where cmd.Type == type && cmd.Source == source select cmd;
            }

            foreach (Command cmd in commands)
            {
                ListViewItem item = new ListViewItem();
                if (itemNo++ % 2 == 0)
                    item.BackColor = alternateRowColor;
                else
                    item.BackColor = Color.White;

                item.Text = cmd.Name;
                item.SubItems.Add(cmd.Type);
                item.SubItems.Add(cmd.Source);
                item.SubItems.Add(cmd.Version);

                listCommands.Items.Add(item);
            }

            listCommands.Enabled = true;
            lblAllCommands.Text = $"Total Commands ( { commands.Count() } )";

            ShowUpdate("");
        }

        private void ParseCommands(string[] input)
        {
            int totalCommands = input.Length;

            string[] command;
            string[] separator = new string[1] { " " };
            //separator[0] = " ";
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
                        Command cmd = new Command();

                        switch (command.Length)
                        {
                            case 1:
                                cmd.Name = command[0];
                                break;

                            case 2:
                                cmd.Name = command[1];
                                cmd.Type = command[0];

                                if (!objAllTypes.Contains(command[0]))
                                {
                                    objAllTypes.Add(command[0]);
                                }

                                break;
                            case 3:
                                cmd.Name = command[1];
                                cmd.Type = command[0];
                                cmd.Source = command[2];

                                if (!objAllTypes.Contains(command[0]))
                                {
                                    objAllTypes.Add(command[0]);
                                }

                                break;
                            case 4:
                                cmd.Name = command[1];
                                cmd.Type = command[0];
                                cmd.Source = command[3];
                                cmd.Version = command[2];

                                if (!objAllTypes.Contains(command[0]))
                                {
                                    objAllTypes.Add(command[0]);
                                }
                                if (!objAllSources.Contains(command[3]))
                                {
                                    objAllSources.Add(command[3]);
                                }

                                break;
                            default:
                                break;
                        }

                        allCommands.Add(cmd);
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
        }

        private void CheckForPowershell()
        {
            string systemFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.System);

            string powerShellFolderPath = Path.Combine(systemFolderPath, powerShellFolder);
            if (Directory.Exists(powerShellFolderPath))
            {
                string powerShellExePath = Path.Combine(powerShellFolderPath, powerShellExe);
                if (File.Exists(powerShellExePath))
                {
                    isPowerShellAvailable = true;
                }
                else
                {
                    string[] directories = Directory.GetDirectories(powerShellFolderPath);
                    foreach (string directory in directories)
                    {
                        powerShellFolderPath = directory;
                        powerShellExePath = Path.Combine(powerShellFolderPath, powerShellExe);

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

            elapsedTime = 0;
            timeout.Elapsed += Timeout_Elapsed;
            timeout.Enabled = false;
            timeout.Start();

            process.Start();

            while (!process.HasExited && !isTimeOut) ;
        }

        private void Timeout_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            elapsedTime++;

            if (elapsedTime > TimeOutValue)
            {
                timeout.Enabled = false;
                timeout.Stop();
                isTimeOut = true;
            }
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
                ShowUpdate($"Getting details for [ {txtCommand.Text} ]");

            command = txtCommand.Text;

            //File.WriteAllText("CommandHelp.txt", "");
            txtCommandHelpDetails.Text = "";

            if (!File.Exists($"{command}-help.txt"))
            {
                GetCommandHelp($"{txtCommand.Text} >> {command}-help.txt");
            }

            txtCommandHelpDetails.Text = File.ReadAllText($"{command}-help.txt");

            txtCommandHelpDetails.Text = ParseCommandHelp(txtCommandHelpDetails.Text);
            ShowUpdate("");

            EnableControls();

            grpDetails.Text = $" {command} ( {txtCommandType.Text} ) >";
            btnFullView.Visible = txtCommandHelpDetails.Text.Length > 0;
            grpDetails.Visible = txtCommandHelpDetails.Text.Length > 0;
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
            txtSource.Text = item.SubItems[2].Text;
            txtVersion.Text = item.SubItems[3].Text;
        }

        private void btnSampleExample_Click(object sender, EventArgs e)
        {
            ShowUpdate($"Getting {((Button)sender).Text} details [ {command} ]");
            GetAdditionalHelpDetails(command, "example");
        }

        private void GetAdditionalHelpDetails(string command, string helpType)
        {
            DisableControls();

            txtCommandHelpDetails.Text = "";
            txtCommandHelpDetails.Refresh();

            GetCommandHelp($"{txtCommand.Text} -{helpType} >> {command}-{helpType}.txt");
            txtCommandHelpDetails.Text = File.ReadAllText($"{command}-{helpType}.txt");

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
            ShowUpdate($"Getting {((Button)sender).Text} details ${command}");
            GetAdditionalHelpDetails(command, "detailed");
        }

        private void btnTechnicalInformation_Click(object sender, EventArgs e)
        {
            ShowUpdate($"Getting {((Button)sender).Text} details ${command}");
            GetAdditionalHelpDetails(command, "full");
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

        private void BtnTheme_Click(object sender, EventArgs e)
        {

        }

        private void CmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCommands(cmbType.Text, cmbSource.Text);
        }

        private void CmbSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCommands(cmbType.Text, cmbSource.Text);
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
