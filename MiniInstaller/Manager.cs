using System;
using System.IO;
using System.Diagnostics;
using System.IO.Compression;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MiniInstaller
{
    public class Manager
    {
        public readonly string InstallerName = "VendstorInstaller";
        public readonly string InstallerKeyName = "VendstorInstaller";
        public readonly string SoftName = "Vendstor";

        public JObject Software { get; set; }
        public EventHandler OnComplete { get; set; }
        public EventHandler OnCatchException { get; set; }
        public App App { get; set; }

        string TempDir
        {
            get { return $@"C:\Users\{Environment.UserName}\AppData\Local\Temp\RigleSoft\{SoftName}\MiniInstaller"; }
        }
        string InstallDir
        {
            get { return $@"C:\Program Files\RigleSoft\{ SoftName }\Installer"; }
        }
        string ShellDir
        {
            get { return $@"C:\ProgramData\RigleSoft\Vendstor\Shell"; }
        }
        string ShellExecutable
        {
            get { return $@"C:\ProgramData\RigleSoft\Vendstor\Shell\Shell.exe"; }
        }
        string DisplayIcon
        {
            get { return $@"C:\ProgramData\RigleSoft\Icons\{SoftName}.ico"; }
        }
        string IconsDir
        {
            get { return $@"C:\ProgramData\RigleSoft\Icons"; }
        }


        public void Initialize()
        {
            if (Util.IsAppInstalled(InstallerName, out string installerKeyName))
            {
                this.OnComplete(this, null);
            }
            else
            {
                try
                {
                    Util.EmptyDirectory(TempDir, true);

                    InitializeShell();
                    GetSoft(Constants.InstallerSoftwareId);
                    AddOrUpdateIcons();
                    InstallInstaller(InstallerKeyName);
                }
                catch(Exception e)
                {
                    this.OnCatchException(e, null);
                }
            }
        }

        private void InitializeShell()
        {
            if (!File.Exists(ShellExecutable))
            {
                Directory.CreateDirectory(ShellDir);

                // Install Shell
                var shell = GetSoft(Constants.ShellSoftwareId, true);
                InstallShell(shell["data"]["software"]["url"].ToObject<string>());
            }
        }

        private void InstallShell(string url)
        {
            var urlFileName = Path.GetFileName(new Uri(url).LocalPath);
            var srcZip = $@"{TempDir}\{urlFileName}";

            Util.DownloadFile(url, srcZip);

            // Extract folder
            var extractDir = $@"{TempDir}\shell";
            ZipFile.ExtractToDirectory(srcZip, extractDir);

            Util.Copy(extractDir, ShellDir);

            // Delete .zip and folder
            File.Delete(srcZip);
            Util.EmptyDirectory(TempDir);
        }

        void AddOrUpdateIcons()
        {
            if (File.Exists(DisplayIcon))
                File.Delete(DisplayIcon);

            Util.CreateDirectory(IconsDir);
            Util.DownloadFile(Constants.IconUrl, DisplayIcon);
        }

        void InstallInstaller(string keyName)
        {
            App app = new App();

            Util.EmptyDirectory(TempDir, true);

            var url = Software["url"].ToObject<string>();
            var urlFileName = Path.GetFileName(new Uri(url).LocalPath);
            var srcZip = $@"{TempDir}\{urlFileName}";

            Util.DownloadFile(url, srcZip);

            // Extract and copy package.json file and delete folder
            var extractDir = $@"{TempDir}\installer";
            ZipFile.ExtractToDirectory(srcZip, extractDir);

            var pkgFilePath = $@"{extractDir}\package.json";
            var jsonData = File.ReadAllText(pkgFilePath);
            var data = (JObject)JsonConvert.DeserializeObject(jsonData);

            // Delete extracted dir
            Directory.Delete(extractDir, true);

            if (Util.GetProperty(data, "name", out object name) != null)
                app.Name = name.ToString();

            if (Util.GetProperty(data, "version", out object version) != null)
                app.Version = version.ToString();

            if (Util.GetProperty(data, "publisher", out object publisher) != null)
                app.Publisher = publisher.ToString();

            if (Util.GetProperty(data, "helpLink", out object helpLink) != null)
                app.HelpLink = helpLink.ToString();

            if (Util.GetProperty(data, "comments", out object comments) != null)
                app.Comments = comments.ToString();

            if (Util.GetProperty(data, "url", out object _url) != null)
                app.UrlInfo = app.UrlUpdateInfo = _url.ToString();

            if (Util.GetProperty(data, "readme", out object readme) != null)
                app.ReadMe = readme.ToString();

            if (Util.GetProperty(data, "executable", out object exe) != null)
                app.Executable = exe.ToString();

            if (Util.GetProperty(data, "uninstallExecutable", out object uninsExe) != null)
                app.UninstallExecutable = uninsExe.ToString();

            App = app;

            app.InstallLocation = InstallDir;
            app.DisplayIcon = DisplayIcon;
            app.UninstallString = $@"{InstallDir}\{app.UninstallExecutable}";

            keyName = (Util.GetProperty(data, "keyName", out object _keyname) ?? keyName).ToString();

            StartProcess(app, "install", keyName, srcZip);
        }

        JObject GetSoft(string softwareId, bool isShell = false)
        {
            var response = Util.GetResponse(softwareId, Constants.ApiAuthToken);
            if (response != null)
            {
                if (!isShell)
                    Software = response["data"]["software"].ToObject<JObject>();
            }
            else
            {
                this.OnCatchException(this, null);
            }
            return response;
        }

        void StartProcess(App app, string task, string appKeyName, string src)
        {
            var shellParams = string.Format(@" {0} -name {1} -v {2} -disicon {3} -pub {4} -helplink {5} -urlinfo  {6} -uninsstr {7} -insloc {8} -comments {9} -readme {10} -akn {11} -src {12} -path {13} ",
                 task, ShellParam(app.Name), ShellParam(app.Version), ShellParam(app.DisplayIcon), ShellParam(app.Publisher), ShellParam(app.HelpLink), ShellParam(app.UrlInfo),
                 ShellParam(app.UninstallString), ShellParam(app.InstallLocation), ShellParam(app.Comments), ShellParam(app.ReadMe), ShellParam(appKeyName), ShellParam(src), ShellParam(InstallDir));

            ProcessStartInfo processInfo = new ProcessStartInfo("cmd.exe");
            processInfo.Arguments = "/k " + $"\"{ ShellExecutable }\"" + " " + $"\"{ shellParams }\"";
            processInfo.CreateNoWindow = true;
            Process process = Process.Start(processInfo);
            process.WaitForExit();

            this.OnComplete(this, null);
        }

        public void StartInstaller()
        {
            try
            {
                if (App.ExePath != null)
                    Process.Start(App.ExePath);
            }
            catch(Exception e)
            {
                this.OnCatchException(e, null);
            }
        }

        string ShellParam(object param)
        {
            return $"\"{ param }\"";
        }
    }
}
