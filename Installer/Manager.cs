using System;
using System.IO;
using System.Diagnostics;
using System.IO.Compression;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Installer
{
    public class Manager
    {
        public readonly string SoftName = "Vendstor";

        public JObject Software { get; set; }
        public EventHandler OnComplete { get; set; }
        public EventHandler OnRequestUpdate { get; set; }
        public EventHandler OnClose { get; set; }
        public EventHandler OnCatchException { get; set; }

        public App InstallerApp { get; set; }
        public App App { get; set; }

        public string ProductVersion { get; set; }
        public string ChangeLog { get; set; }

        string TempDir
        {
            get { return $@"C:\Users\{Environment.UserName}\AppData\Local\Temp\RigleSoft\{SoftName}\Installer"; }
        }
        string InstallDir
        {
            get { return $@"C:\Program Files\RigleSoft\{ SoftName }\{ SoftName }"; }
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
            // Check if Installer is UpToDate            
            if (Util.IsUpToDate(Constants.InstallerSoftwareId, ProductVersion))
            {
                try
                {

                    Util.EmptyDirectory(TempDir, true);
                    InitializeShell();
                    GetSoft(Constants.VendstorSoftwareId);
                    AddOrUpdateIcons();

                    // Convert response or files to properties
                    ImportAppPackge();
                    ImportSoftwareProps();
                }
                catch (Exception e)
                {
                    this.OnCatchException(e, null);
                }
               
                ImportRegistryProps();
            }
            else
                this.OnRequestUpdate(this, null);
        }

        #region Shell

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

        #endregion

        #region App

        public void InstallOrUpdateApp()
        {
            var url = Software["url"].ToObject<string>();
            var urlFileName = Path.GetFileName(new Uri(url).LocalPath);
            var srcZip = $@"{TempDir}\{urlFileName}";

            App app = new App();
            app = App;
            app.InstallLocation = InstallDir;
            app.DisplayIcon = DisplayIcon;
            app.UninstallString = $@"{InstallDir}\{app.UninstallExecutable}";
            StartProcess(app, "install", app.KeyName.ToString(), srcZip);
        }

        public void UninstallApp()
        {
            App app = new App();
            app = App;
            app.InstallLocation = InstallDir;
            StartProcess(app, "uninstall", app.KeyName.ToString());
        }

        void ImportAppPackge(string keyname = null, string tempdir = "installer_app")
        {
            App app = new App();

            Util.EmptyDirectory(TempDir, true);

            var url = Software["url"].ToObject<string>();
            var urlFileName = Path.GetFileName(new Uri(url).LocalPath);
            var srcZip = $@"{TempDir}\{urlFileName}";

            Util.DownloadFile(url, srcZip);

            // Extract and copy package.json file and delete folder
            var extractDir = $@"{TempDir}\{tempdir}";
            ZipFile.ExtractToDirectory(srcZip, extractDir);

            var pkgFilePath = $@"{extractDir}\package.json";
            var jsonData = File.ReadAllText(pkgFilePath);
            var data = (JObject)JsonConvert.DeserializeObject(jsonData);

            var changeLogPath = $@"{extractDir}\changelog.md";
            ChangeLog = File.ReadAllText(changeLogPath);

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

            if (Util.GetProperty(data, "description", out object description) != null)
                app.Description = uninsExe.ToString();

            if (Util.GetProperty(data, "keyName", out object _keyname) != null)
                app.KeyName = keyname ?? _keyname;
            App = app;
        }

        void ImportSoftwareProps()
        {
            LastestApp lastestApp = new LastestApp();
            if (Util.GetProperty(Software, "softId", out object softId) != null)
                lastestApp.SoftId = softId.ToString();

            if (Util.GetProperty(Software, "id", out object id) != null)
                lastestApp.Id = id.ToString();

            if (Util.GetProperty(Software, "name", out object name) != null)
                lastestApp.Name = name.ToString();

            if (Util.GetProperty(Software, "version", out object version) != null)
                lastestApp.Version = version.ToString();


            if (Util.GetProperty(Software, "url", out object url) != null)
                lastestApp.Url = url.ToString();


            if (Util.GetProperty(Software, "note", out object note) != null)
                lastestApp.Note = note.ToString();


            if (Util.GetProperty(Software, "build", out object build) != null)
                lastestApp.Build = build.ToString();


            if (Util.GetProperty(Software, "guid", out object guid) != null)
                lastestApp.GUID = guid.ToString();


            if (Util.GetProperty(Software, "releasedAt", out object releasedAt) != null)
                lastestApp.ReleasedAt = Convert.ToDateTime(releasedAt);

            App.Lastest = lastestApp;
        }

        public void ImportRegistryProps()
        {
            var appKeyName = App.KeyName.ToString();
            if (!Util.KeyExists(appKeyName, "DisplayName"))
                return;
            App.InstallLocation = Util.GetRegistryProperty(appKeyName, "InstallLocation");
        }

        #endregion

        void AddOrUpdateIcons()
        {
            if (File.Exists(DisplayIcon))
                File.Delete(DisplayIcon);

            Util.CreateDirectory(IconsDir);
            Util.DownloadFile(Constants.IconUrl, DisplayIcon);
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

        void StartProcess(App app, string task, string appKeyName, string src = "")
        {
            var shellParams = "";
            if (task.ToLower() == "install" || task.ToLower() == "update")
            {
                shellParams = string.Format(@" {0} -name {1} -v {2} -disicon {3} -pub {4} -helplink {5} -urlinfo  {6} -uninsstr {7} -insloc {8} -comments {9} -readme {10} -akn {11} -src {12} -path {13} -desc {14} -exe {15}",
                task, ShellParam(app.Name), ShellParam(app.Version), ShellParam(app.DisplayIcon), ShellParam(app.Publisher), ShellParam(app.HelpLink), ShellParam(app.UrlInfo),
                ShellParam(app.UninstallString), ShellParam(app.InstallLocation), ShellParam(app.Comments), ShellParam(app.ReadMe), ShellParam(appKeyName), ShellParam(src), ShellParam(InstallDir),
                ShellParam(app.Description), ShellParam(app.Executable));
            }
            else
            {
                shellParams = string.Format(@" {0} -akn {1} -path {2} ", task, ShellParam(appKeyName), ShellParam(InstallDir));
            }

            ProcessStartInfo processInfo = new ProcessStartInfo("cmd.exe")
            {
                Arguments = "/k " + $"\"{ ShellExecutable }\"" + " " + $"\"{ shellParams }\"",
                CreateNoWindow = true
            };
            Process process = Process.Start(processInfo);
            process.WaitForExit();

            this.OnComplete(this, null);
        }

        public void StartApp()
        {
            try
            {
                if (App.ExePath != null)
                    Process.Start(App.ExePath);

            }
            catch { return; }
        }

        string ShellParam(object param)
        {
            return $"\"{ param }\"";
        }
    }
}
