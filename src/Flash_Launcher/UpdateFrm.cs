using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Net;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flash_Launcher
{
    public partial class UpdateFrm : Form
    {
        public UpdateFrm()
        {
            InitializeComponent();
        }

        private bool isUpdate = false;

        private void UpdateFrm_Load(object sender, EventArgs e)
        {
            using (WebClient wc = new WebClient())
            {
                wc.CachePolicy = new System.Net.Cache.RequestCachePolicy(System.Net.Cache.RequestCacheLevel.NoCacheNoStore);
                string latest = wc.DownloadString(Core.UpdateURL);
                latest = latest.Trim();
                Version v = Version.Parse(latest);
                lblCVersion.Text = "App Version: " + Core.AppVersion.ToString();
                lblLVersion.Text = "Latest Version: " + latest;
                if (Core.AppVersion < v)
                {
                    isUpdate = true;
                    lblInfo.Text = "Update required...";
                }
            }
            if (!isUpdate)
            {
                btnUpdate.Text = "Close";
                lblInfo.Text = "You are using the latest version.";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!isUpdate)
            {
                Close();
            }
            else
            {
                System.Diagnostics.Process.Start("https://github.com/redsensegames/flash-launcher/releases");
                Environment.Exit(0x0);
            }
        }
    }
}
