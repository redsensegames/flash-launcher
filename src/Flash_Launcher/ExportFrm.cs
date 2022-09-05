using System;
using System.IO;
using System.Windows.Forms;

namespace Flash_Launcher
{
    public partial class ExportFrm : Form
    {
        public ExportFrm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Flash Object|*.swf";
                sfd.FileName = txtName.Text;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        File.Copy(Folders.DatabaseFolder + txtName.Text + ".swf", sfd.FileName);
                        MessageBox.Show("Export completed!", "Red Sense Games");
                        Close();
                    }
                    catch (UnauthorizedAccessException ex)
                    {
                        MessageBox.Show("Error: Unauthorized Access\nMessage:" + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
    }
}
