using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flash_Launcher
{
    public partial class SettingsFrm : Form
    {
        public SettingsFrm()
        {
            InitializeComponent();
        }

        private void SettingsFrm_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Compressed file|*.zip";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ZipFile.CreateFromDirectory(Folders.DatabaseFolder, sfd.FileName);
                    MessageBox.Show("Backup saved.", "Flash Launcher", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Open the database folder and copy the data you previously backed up to the database folder.", "Flash Launcher", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnOpenDB_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Folders.DatabaseFolder);
        }
    }
}
