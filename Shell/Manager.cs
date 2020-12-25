using System;
using System.IO;
using System.IO.Compression;
using IWshRuntimeLibrary;

namespace Shell
{
    public static class Manager
    {
        static readonly string n = Environment.NewLine;

        internal static string TempDir
        {
            get { return string.Format(@"C:\Users\{0}\AppData\Local\Temp\RigleSoft\Vendstor\Shell", Environment.UserName); }
        }
        static bool CanAddShortcut(string appName)
        {
            return !appName.ToLower().Contains("installer");
        }

        public static void Install(App app, string appKeyName, string source, string path)
        {
            try
            {
                Util.WriteLine($"Task : Install, KeyName : { appKeyName }, {n} Source : {source}, Path : {path} ", ConsoleColor.DarkCyan);
                Util.WriteLine($"Installing...", ConsoleColor.DarkCyan);

                Util.WriteLine($"Adding Locally...", ConsoleColor.DarkCyan);
                AddOrEdit(source, path);

                // Registry 
                Util.WriteLine($"Adding To Registry...", ConsoleColor.DarkCyan);
                RegistryUtil.AddProgram(app, appKeyName);

                //ShortCut
                if (CanAddShortcut(app.Name))
                {
                    Util.WriteLine($"Creating Shortcut...", ConsoleColor.DarkCyan);
                    AddShortcut(app.ExePath, appKeyName, app.Name, app.Description, app.DisplayIcon.ToString());
                }

                Util.WriteLine($"Installation Succeeded", ConsoleColor.Green);
            }
            catch (Exception e)
            {
                Util.WriteLine(e, ConsoleColor.Red);
                Console.ReadLine();
            }
        }

        public static void Update(App app, string appKeyName, string source, string path)
        {
            try
            {
                Util.WriteLine($"Task : Update, KeyName : { appKeyName }, {n} Source : {source}, Path : {path} ", ConsoleColor.DarkCyan);
                Util.WriteLine($"Updating...", ConsoleColor.DarkCyan);

                Util.WriteLine($"Updating Locally...", ConsoleColor.DarkCyan);
                AddOrEdit(source, path);

                // Registry 
                Util.WriteLine($"Updating Registry...", ConsoleColor.DarkCyan);
                RegistryUtil.UpdateProgram(app, appKeyName);

                //ShortCut
                if (CanAddShortcut(app.Name))
                {
                    Util.WriteLine($"Updating Shortcut...", ConsoleColor.DarkCyan);
                    AddShortcut(app.ExePath, appKeyName, app.Name, app.Description, app.DisplayIcon.ToString());
                }

                Util.WriteLine($"Update Succeeded", ConsoleColor.Green);
            }
            catch (Exception e)
            {
                Util.WriteLine(e, ConsoleColor.Red);
                Console.ReadLine();
            }
        }

        public static void Uninstall(string appKeyName, string path)
        {
            try
            {
                Util.WriteLine($"Task : Uninstall, KeyName : { appKeyName }, {n} Path : {path} ", ConsoleColor.DarkCyan);
                Remove(path);

                // Remove Shortcut
                if (CanAddShortcut(appKeyName))
                {
                    Util.WriteLine($"Removing Shortcut...", ConsoleColor.DarkCyan);
                    RemoveShortcut(appKeyName);
                }


                // Registry 
                Util.WriteLine($"Removing from Registry...", ConsoleColor.DarkCyan);
                RegistryUtil.RemoveProgram(appKeyName);

                Util.WriteLine($"Uninstallation Succeeded", ConsoleColor.Green);
            }
            catch (Exception e)
            {
                Util.WriteLine(e, ConsoleColor.Red);
                Console.ReadLine();
            }
        }

        /// <summary>
        /// Create or Extract, Copy & Paste from source to path
        /// </summary>
        private static void AddOrEdit(string source, string path)
        {
            Util.WriteLine($"Cleaning Directory : { TempDir }");
            Util.EmptyDirectory(TempDir, true);

            var extractDir = $@"{TempDir}\app";

            if (Util.IsArchive(source))
            {
                Util.WriteLine($"Extracting from Source :  { source }  to Path : { extractDir }");
                ZipFile.ExtractToDirectory(source, extractDir);
            }

            Util.WriteLine($"Cleaning Path : { path }");
            // Delete target directory files recursively
            if (Directory.Exists(path))
                new DirectoryInfo(path).Delete(true);
            else
                Directory.CreateDirectory(path);

            Util.WriteLine($"Adding Software to Path : { path }");
            // Copy from extracted dir to path
            Util.Copy(extractDir, path);

            Util.WriteLine($"Cleaing temps at : { TempDir }");
            // Delete files
            Util.EmptyDirectory(extractDir);
            Directory.Delete(extractDir, true);
        }

        /// <summary>
        /// Delete all files recursively and delete directory path
        /// </summary>
        private static void Remove(string path)
        {
            if (Directory.Exists(path))
            {
                Util.WriteLine($"Deleting all files and directories recursively from  : { path }");
                Util.EmptyDirectory(path);
                Directory.Delete(path, true);
            }
        }

        /// <summary>
        /// Add Start Menu Shortcut
        /// </summary>
        public static void AddShortcut(string exePath, string name, string shortcutName, string description, string iconLocation)
        {
            var commonStartMenuPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonStartMenu);
            var appStartMenuPath = Path.Combine(commonStartMenuPath, "Programs", name);

            if (!Directory.Exists(appStartMenuPath))
                Directory.CreateDirectory(appStartMenuPath);

            var shortcutLocation = Path.Combine(appStartMenuPath, shortcutName + ".lnk");
            WshShell shell = new WshShell();
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutLocation);

            shortcut.Description = description;
            shortcut.IconLocation = iconLocation;
            shortcut.TargetPath = exePath;
            shortcut.Save();
        }
        
        /// <summary>
        /// Remove Start Menu Shortcut
        /// </summary>
        public static void RemoveShortcut(string name)
        {
            var commonStartMenuPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonStartMenu);
            var appStartMenuPath = Path.Combine(commonStartMenuPath, "Programs", name);

            if (Directory.Exists(appStartMenuPath))
            {
                Util.EmptyDirectory(appStartMenuPath);
                Directory.Delete(appStartMenuPath, true);
            }
        }
    }
}
