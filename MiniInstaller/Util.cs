using System;
using System.Net;
using System.IO;

using System.Linq;
using System.Text;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Microsoft.Win32;
using System.Windows.Forms;

namespace MiniInstaller
{
    public static class Util
    {
        #region Variables 

        internal static string MicrosoftRegKey = @"Software\Microsoft\Windows\CurrentVersion\Uninstall";
        internal static string Wow6432NodeRegKey = @"SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall";

        #endregion

        #region Data

        public static object GetProperty(object data, string key, out object value)
        {
            try
            {
                value = ((JObject)data)[key];
                return ((JObject)data)[key];
            }
            catch
            {
                value = null;
                return null;
            }
        }

        /// <summary>
        ///     Checks if input is a valid JSON string
        /// </summary>
        public static bool IsJson(string strInput)
        {
            strInput = strInput.Trim();
            if ((strInput.StartsWith("{") && strInput.EndsWith("}")) || //For object
                (strInput.StartsWith("[") && strInput.EndsWith("]"))) //For array
            {
                try
                {
                    var obj = JToken.Parse(strInput);
                    return true;
                }
                catch (JsonReaderException jex)
                {
                    //Exception in parsing json
                    Console.WriteLine(jex.Message);
                    return false;
                }
                catch (Exception ex) //some other exception
                {
                    Console.WriteLine(ex.ToString());
                    return false;
                }
            }
            else
            {
                return false;
            }

        }

        public static JObject GetResponse(string id, string authToken)
        {
            var url = string.Format(@"{0}/software?softwareId={1}&authToken={2}", Constants.ApiUrl, id, authToken);
            var jsonData = DownloadString(url);

            if (!IsJson(jsonData.ToString()))
                return null;

            return (JObject)JsonConvert.DeserializeObject(jsonData.ToString());
        }

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

        #endregion

        #region Network  & Requests

        /// <summary>
        ///    Downloads content from the url to the specified path with fileName inclusive.
        /// </summary>
        public static void DownloadFile(string url, string fileName)
        {
            using (WebClient client = new WebClient())
            {
                client.DownloadFile(url, fileName);
            }
        }

        /// <summary>
        ///     Download String from url
        /// </summary>
        public static object DownloadString(string url)
        {
            try
            {
                using (WebClient webClient = new WebClient { Encoding = Encoding.UTF8 })
                {
                    return webClient.DownloadString(new Uri(url));
                }
            }
            catch (WebException)
            {
                return null;
            }
        }

        #endregion

        #region File & Directory Management 

        public static void CreateDirectory(string path, bool createNotExists = true)
        {
            if (createNotExists)
                if (Directory.Exists(path))
                    return;

            Directory.CreateDirectory(path);
        }

        /// <summary>
        ///   Gets a file Name e.g in  "test.extenstion" returns  test
        /// </summary>
        public static string GetFileName(string path, bool withoutExtension = true)
        {
            FileInfo file = new FileInfo(path);
            if (withoutExtension)
                return file.Name.Replace(file.Extension, "");
            else
                return file.Name;
        }

        /// <summary>
        ///     Deletes all files in a directory (path) 
        ///     except if fileName or directory is in array (fileSkipList or dirSkipList)
        /// </summary>
        public static void EmptyDirectory(string path, bool createNotExists = false, string[] fileSkipList = null, string[] dirSkipList = null)
        {
            if (createNotExists)
            {
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
            }

            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            foreach (FileInfo file in directoryInfo.GetFiles())
            {
                if (fileSkipList != null)
                {
                    foreach (var skipFile in fileSkipList)
                        if (file.Name != skipFile)
                            file.Delete();
                }
                else
                    file.Delete();
            }
            foreach (DirectoryInfo directory in directoryInfo.GetDirectories())
            {
                if (dirSkipList != null)
                {
                    foreach (var skipFile in dirSkipList)
                        if (directory.Name != skipFile)
                            directory.Delete(true);
                }
                else
                    directory.Delete(true);
            }
        }

        /// <summary>
        ///     Creates a new file and copy paste the content of sourceDir to targetDir
        /// </summary>
        public static void Copy(string sourceDir, string targetDir, bool overwrite = true)
        {
            if (!Directory.Exists(targetDir))
                Directory.CreateDirectory(targetDir);
            string[] files = Directory.GetFiles(sourceDir);
            foreach (string file in files)
            {
                string name = Path.GetFileName(file);
                string dest = Path.Combine(targetDir, name);
                File.Copy(file, dest, overwrite);
            }
            string[] folders = Directory.GetDirectories(sourceDir);
            foreach (string folder in folders)
            {
                string name = Path.GetFileName(folder);
                string dest = Path.Combine(targetDir, name);
                Copy(folder, dest, overwrite);
            }
        }

        #endregion

        public static void SetIcon(Form form)
        {
            form.Icon = Properties.Resources.vendstor_big;
        }
    }
}

