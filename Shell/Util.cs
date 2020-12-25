using System;
using System.Net;
using System.IO;

namespace Shell
{
    public static class Util
    {
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
        ///     Checks if a source path is an archive
        /// </summary>
        public static bool IsArchive(string source)
        {
            return !Directory.Exists(source);
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

        public static void Write(object value, ConsoleColor applyColor = ConsoleColor.White, ConsoleColor defaultColor = ConsoleColor.White)
        {
            Console.ForegroundColor = applyColor;
            Console.Write(value);
            Console.ForegroundColor = defaultColor;
        }
        public static void WriteLine(object value, ConsoleColor applyColor = ConsoleColor.White, ConsoleColor defaultColor = ConsoleColor.White)
        {
            Console.ForegroundColor = applyColor;
            Console.WriteLine(value);
            Console.ForegroundColor = defaultColor;
        }
    }
}

