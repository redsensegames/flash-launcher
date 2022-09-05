using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flash_Launcher
{
    public partial class AddApp : Form
    {
        public AddApp()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public string AppName { get; set; }
        public string AppPath { get; set; }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Flash Object|*.swf";
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                lblName.Text = ofd.FileName;
                AppName = Path.GetFileNameWithoutExtension(ofd.FileName);
                AppPath = Path.GetFullPath(ofd.FileName);
                txtName.Text = AppName;
                btnSave.Enabled = true;
                txtName.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (File.Exists(Folders.DatabaseFolder + txtName.Text + ".swf"))
            {
                MessageBox.Show("A file with the name you specified already exists. Please specify another name.", "Flash Launcher", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (checkBoxMode.Checked)
                {
                    File.Move(AppPath, Folders.DatabaseFolder + txtName.Text + ".swf");
                }
                else
                {
                    File.Copy(AppPath, Folders.DatabaseFolder + txtName.Text + ".swf");
                }
                Close();
            }
        }

        private void AddApp_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            txtName.Enabled = false;
        }

        private void linkWhatIsFull_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("When you want to import your files, Flash Launcher copies the file into its database. This takes up a lot of space on your disk. With the Full Import option, the imported file is moved to the database and you gain space from the disk.", "Flash Launcher", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
