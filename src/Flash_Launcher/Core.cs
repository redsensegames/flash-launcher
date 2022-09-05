using System;
using System.Diagnostics;
using System.Reflection;

namespace Flash_Launcher
{
    internal static class Core
    {
        internal static Version AppVersion = Assembly.GetExecutingAssembly().GetName().Version;
        internal static string UpdateURL = "https://raw.githubusercontent.com/redsensegames/flash-launcher/main/update/latest.version";
        
        internal static void RunApp(string path)
        {
            using (Process p = new Process())
            {
                p.StartInfo.FileName = Folders.DataFolder + "Adobe\\flashplayer_32_sa.exe";
                p.StartInfo.Arguments = "\"" + path + "\"";
                p.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
                p.Start();
            }
        }
    }
}
