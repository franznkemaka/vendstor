using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Uninstaller
{
    public static class Util
    {
        #region Variables 

        internal static string MicrosoftRegKey = @"Software\Microsoft\Windows\CurrentVersion\Uninstall";
        internal static string Wow6432NodeRegKey = @"SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall";

        #endregion

        #region Registry

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

        public static bool KeyExists(string keyName, string valueName)
        {
            RegistryKey hKey = (Registry.LocalMachine).OpenSubKey(Wow6432NodeRegKey, true);
            RegistryKey appKey = hKey.CreateSubKey(keyName);
            return appKey.GetValue(valueName) != null;
        }

        public static object GetKeyValue(string keyName, string valueName)
        {
            RegistryKey hKey = (Registry.LocalMachine).OpenSubKey(Wow6432NodeRegKey, true);
            RegistryKey appKey = hKey.CreateSubKey(keyName);
            return appKey.GetValue(valueName);
        }

        public static bool PathExists(string keyName, string valueName)
        {
            try
            {

                RegistryKey hKey = (Registry.LocalMachine).OpenSubKey(Wow6432NodeRegKey, true);
                RegistryKey appKey = hKey.CreateSubKey(keyName);

                var path = appKey.GetValue(valueName);
                return Directory.Exists(path.ToString());
            }
            catch { return false; }
        }
        #endregion

        public static void SetIcon(Form form)
        {
            form.Icon = Properties.Resources.vendstor_big;
        }
    }
}

