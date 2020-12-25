using System;
using System.Diagnostics;

namespace Uninstaller
{
    public class Manager
    {
        public EventHandler OnComplete { get; set; }
        public EventHandler OnCatchException { get; set; }

        string ShellExecutable
        {
            get { return $@"C:\ProgramData\RigleSoft\Vendstor\Shell\Shell.exe"; }
        }

        public void Initialize()
        {
            var keyName = Constants.VendstorAppName;
            // Open Shell with install path and keyName           
            var path = Util.GetKeyValue(keyName, "InstallLocation");
            StartProcess("uninstall", keyName, path.ToString());
        }

        void StartProcess(string task, string appKeyName, string path)
        {
            try
            {
                var shellParams = string.Format(@" {0} -akn {1} -path {2} ", task, ToShellParam(appKeyName), ToShellParam(path));

                ProcessStartInfo processInfo = new ProcessStartInfo("cmd.exe");
                processInfo.Arguments = "/k " + $"\"{ ShellExecutable }\"" + " " + $"\"{ shellParams }\"";
                processInfo.CreateNoWindow = true;
                Process process = Process.Start(processInfo);
                process.WaitForExit();

                this.OnComplete(this, null);
            }
            catch (Exception e)
            {
                this.OnCatchException(e, null);
            }

        }

        string ToShellParam(object param)
        {
            return $"\"{ param }\"";
        }
    }
}
