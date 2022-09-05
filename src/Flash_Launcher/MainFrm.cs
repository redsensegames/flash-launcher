using System;
using System.IO;
using System.Windows.Forms;

namespace Flash_Launcher
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void FlashLauncherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Flash Launcher\nCopyright 2022 Red Sense Games. All Rights Reserved.", "About Flash Launcher");
        }

        private void AdobeFlashPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Adobe Flash Player 32\nhttp://www.adobe.com\nCopyright 1996-2020 Adobe. All Rights Reserved.", "About Adobe Flash Player");
        }

        private void ImportFlashObjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddApp().ShowDialog();
            RefreshApps();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0x0);
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            CreateDB();
            RefreshApps();
        }

        private void CreateDB()
        {
            if (!Directory.Exists(Folders.DatabaseFolder))
            {
                try
                {
                    Directory.CreateDirectory(Folders.DatabaseFolder);
                    Directory.CreateDirectory(Folders.DataFolder);
                    Directory.CreateDirectory(Folders.DataFolder + "Adobe\\");
                    File.WriteAllBytes(Folders.DataFolder + "Adobe\\flashplayer_32_sa.exe", Properties.Resources.flashplayer_32_sa);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void RefreshApps()
        {
            listView1.Items.Clear();
            DirectoryInfo di = new DirectoryInfo(Folders.DatabaseFolder);
            foreach (FileInfo file in di.GetFiles("*.swf"))
            {
                listView1.Items.Add(file.Name.Remove(file.Name.Length - file.Extension.Length), 0);
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            string file = listView1.SelectedItems[0].Text + ".swf";
            Core.RunApp(Folders.DatabaseFolder + file);
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var focusedItem = listView1.FocusedItem;
                if (focusedItem != null && focusedItem.Bounds.Contains(e.Location))
                {
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string file = listView1.SelectedItems[0].Text + ".swf";
            Core.RunApp(Folders.DatabaseFolder + file);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string file = listView1.SelectedItems[0].Text + ".swf";
            if (MessageBox.Show("Are you sure you want to permanently delete " + listView1.SelectedItems[0].Text + "?", "Flash Launcher", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                File.Delete(Folders.DatabaseFolder + file);
                RefreshApps();
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string file = listView1.SelectedItems[0].Text;
            ExportFrm exp = new ExportFrm();
            exp.txtName.Text = file;
            exp.ShowDialog();
        }

        private void checkForUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UpdateFrm().ShowDialog();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SettingsFrm().ShowDialog();
        }
    }
}
