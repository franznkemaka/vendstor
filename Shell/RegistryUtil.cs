using System;
using System.Linq;
using Microsoft.Win32;

namespace Shell
{
    public static class RegistryUtil
    {
        internal static string MicrosoftRegKey = @"Software\Microsoft\Windows\CurrentVersion\Uninstall";
        internal static string Wow6432NodeRegKey = @"SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall";

        public static bool IsAppInstalled(string appName, out string appKeyName)
        {
            string displayName;
            RegistryKey key = Registry.LocalMachine.OpenSubKey(MicrosoftRegKey);

            if (key != null)
            {
                foreach (RegistryKey subkey in key.GetSubKeyNames().Select(keyName => key.OpenSubKey(keyName)))
                {
                    displayName = subkey.GetValue("DisplayName") as string;
                    appKeyName = subkey.ToString();

                    if (!string.IsNullOrEmpty(displayName) && displayName.Contains(appName))
                        return true;
                }
                key.Close();
            }
            key = Registry.LocalMachine.OpenSubKey(Wow6432NodeRegKey);
            if (key != null)
            {
                foreach (RegistryKey subkey in key.GetSubKeyNames().Select(keyName => key.OpenSubKey(keyName)))
                {
                    displayName = subkey.GetValue("DisplayName") as string;
                    appKeyName = subkey.ToString();
                    if (!string.IsNullOrEmpty(displayName) && displayName.Contains(appName))
                        return true;
                }
                key.Close();
            }
            appKeyName = null;
            return false;
        }

        public static void AddProgram(App app, string appKeyName)
        {
            try
            {
                RegistryKey hKey = (Registry.LocalMachine).OpenSubKey(Wow6432NodeRegKey, true);
                RegistryKey appKey = hKey.CreateSubKey(appKeyName);

                if (app.Name != null)
                    appKey.SetValue("DisplayName", app.Name, RegistryValueKind.String);

                if (app.Version != null)
                    appKey.SetValue("DisplayVersion", app.Version, RegistryValueKind.String);

                if (app.Publisher != null)
                    appKey.SetValue("Publisher", app.Publisher, RegistryValueKind.String);

                if (app.HelpLink != null)
                    appKey.SetValue("HelpLink", app.HelpLink, RegistryValueKind.String);

                if (app.UninstallString != null)
                    appKey.SetValue("UninstallString", app.UninstallString, RegistryValueKind.ExpandString);

                if (app.InstallLocation != null)
                    appKey.SetValue("InstallLocation", app.InstallLocation, RegistryValueKind.ExpandString);

                if (app.DisplayIcon != null)
                    appKey.SetValue("DisplayIcon", app.DisplayIcon, RegistryValueKind.String);

                if (app.Comments != null)
                    appKey.SetValue("Comments", app.Comments, RegistryValueKind.String);

                if (app.UrlInfo != null)
                {
                    appKey.SetValue("URLInfo", app.UrlInfo, RegistryValueKind.String);
                    appKey.SetValue("URLInfoAbout", app.UrlInfo, RegistryValueKind.String);
                }

                if (app.ReadMe != null)
                    appKey.SetValue("ReadMe", app.ReadMe, RegistryValueKind.String);

                appKey.Close();
            }
            catch (Exception e)
            {
                Util.WriteLine(e, ConsoleColor.Red);
            }
        }

        public static void UpdateProgram(App app, string appKeyName)
        {
            AddProgram(app, appKeyName);
        }

        public static void RemoveProgram(string appKeyName)
        {
            try
            {
                RegistryKey hKey = (Registry.LocalMachine).OpenSubKey(Wow6432NodeRegKey, true);
                RegistryKey appKey = hKey.CreateSubKey(appKeyName);
                appKey.DeleteSubKey(appKeyName);
            }
            catch(Exception e)
            {
                Util.WriteLine(e, ConsoleColor.Red);
            }
        }
    }
}