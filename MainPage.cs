using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace UnityWebGl_LocalHoster
{
    public partial class MainPage : Form
    {
        string processName;
        ComboBox version_CB;
        private string folderPath = "";
        bool isStart = true;

        public MainPage()
        {
            InitializeComponent();
        }
        private void MainPage_Load(object sender, EventArgs e)
        {
            // Creating and setting the properties of comboBox
            version_CB = new ComboBox();
            version_CB.Location = new Point(231, 265);
            version_CB.Size = new Size(92, 22);
            version_CB.Name = "version_CB";
            version_CB.DropDownStyle = ComboBoxStyle.DropDownList;

            //Get all unity versions
            string rootPath = @"C:\Program Files\Unity\Hub\Editor";
            string[] dirs = Directory.GetDirectories(rootPath, "*", SearchOption.TopDirectoryOnly);

            foreach (string dir in dirs)
            {
                if(!Directory.Exists(dir + @"\Editor\Data\PlaybackEngines\WebGLSupport\BuildTools"))
                {
                    continue;
                }

                var version = dir.Remove(0, rootPath.Length + 1);
                version_CB.Items.Add(version);
            }

            // Adding this ComboBox to the form
            this.Controls.Add(version_CB);

            //tool tip
            gamePath_toolTip.SetToolTip(gamePath_L, "required | Choose your WebGl game folder");
            gamePath_toolTip.SetToolTip(gamePath_BTN, "required | Choose your WebGl game folder");
            gamePath_toolTip.SetToolTip(port_L, "optional | Port number by default is 8000");
            gamePath_toolTip.SetToolTip(port_TB, "optional | Port number by default is 8000");
            gamePath_toolTip.SetToolTip(version_L, "optional | unity webgl build version");
            gamePath_toolTip.SetToolTip(version_CB, "optional | unity webgl build version");
        }
        private void gamePath_BTN_Click(object sender, EventArgs e)
        {
            var dlg = new FolderPicker();
            dlg.InputPath = @"C:\Users\";
            if (dlg.ShowDialog(Handle) == true)
            {
                folderPath = dlg.ResultPath;
                folderPathName_L.Text = folderPath;
                folderPath = " \"" + folderPath + "\" ";
            }
        }

        private void start_BTN_Click(object sender, EventArgs e)
        {
            isStart = !isStart;

            if (isStart)
            {
                start_BTN.Text = "start localhost";
                localhostLink_L.Text = "";
                StopHost();
                return;
            }
            start_BTN.Text = "stop localhost";

            if (folderPathName_L.Text == "")
            {
                MessageBox.Show("No WebGl folder was selected!\nselect a folder and try again", "No folder selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string unityWebGlHosterPath;
            
            if (version_CB.Text == "")
            {
                unityWebGlHosterPath = "SimpleWebServer.exe";
            }
            else
            {
                unityWebGlHosterPath = $"C:\\\"Program Files\"\\Unity\\Hub\\Editor\\{version_CB.Text}\\Editor\\Data\\PlaybackEngines\\WebGLSupport\\BuildTools\\SimpleWebServer.exe";
            }

            var command = unityWebGlHosterPath + folderPath + GetPort();

            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C " + command;
            process.StartInfo = startInfo;
            process.Start();
            processName = process.ProcessName;

            //show localhost link
            localhostLink_L.Text = "http://localhost:" + port_TB.Text;
            localhostLink_L_Click(null, null);
        }
        private void localhostLink_L_Click(object sender, EventArgs e)
        {
            Process.Start(localhostLink_L.Text);
        }

        private string GetPort()
        {
            //Default port 8000 
            //if no or wrong port provided
            if(int.TryParse(port_TB.Text, out var num))
                return port_TB.Text;
            return "8000";
        }

        private void MainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopHost();
        }

        private void StopHost()
        {
            foreach (Process current in Process.GetProcessesByName(processName))
            {
                current.Kill();
                current.WaitForExit();
            }
            foreach (Process current in Process.GetProcessesByName("SimpleWebServer"))
            {
                current.Kill();
                current.WaitForExit();
            }
        }

    }
}
