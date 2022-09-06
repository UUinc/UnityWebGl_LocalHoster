using System;
using System.Windows.Forms;

namespace UnityWebGl_LocalHoster
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void gamePath_BTN_Click(object sender, EventArgs e)
        {
            var dlg = new FolderPicker();
            dlg.InputPath = @"C:\Users\";
            if (dlg.ShowDialog(Handle) == true)
            {
                MessageBox.Show(dlg.ResultPath);
            }
        }

    }
}
