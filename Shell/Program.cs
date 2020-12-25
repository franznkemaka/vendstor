using System;

namespace Shell
{
    class Program
    {
        public static string[] Arguments { get; set; }
        public static RequestTask CurrentTask { get; set; }
        public enum RequestTask { Install, Update, Uninstall, Download, Extract, Default }

        public static string Task
        {
            get { return GetArgument(Arguments, 0); }
        }
        public static App App
        {
            get
            {
                return new App
                {
                    Name = GetParamsValue(Arguments, new string[] { "-disname", "-name" }),
                    Version = GetParamsValue(Arguments, new string[] { "-v", "-ver" }),
                    Icon = GetParamValue(Arguments, "-disicon"),
                    Publisher = GetParamValue(Arguments, "-pub"),
                    HelpLink = GetParamValue(Arguments, "-helplink"),
                    HelpTelephone = GetParamValue(Arguments, "-helptel"),
                    UrlInfo = GetParamValue(Arguments, "-urlinfo"),
                    UrlUpdateInfo = GetParamValue(Arguments, "-urlupdinfo"),
                    ModifyPath = GetParamValue(Arguments, "-modifyp"),

                    UninstallString = GetParamValue(Arguments, "-uninsstr"),
                    SettingsIdentifier = GetParamValue(Arguments, "-setsid"),

                    InstallDate = GetParamValue(Arguments, "-insdate"),
                    InstallLocation = GetParamValue(Arguments, "-insloc"),
                    InstallSource = GetParamValue(Arguments, "-inssrc"),

                    Comments = GetParamValue(Arguments, "-comments"),
                    EstimatedSize = GetParamValue(Arguments, "-essize"),
                    Language = GetParamValue(Arguments, "-lang"),
                    ReadMe = GetParamValue(Arguments, "-readme"),

                    Executable = GetParamsValue(Arguments, new string[] { "-exe", "-executable" }),
                    Description = GetParamsValue(Arguments, new string[] { "-desc", "-description" }),
                };
            }
        }
        /// Can be path or with fileName inclusive
        public static string Source
        {
            get { return GetParamsValue(Arguments, new string[] { "-s", "-src" }); }
        }
        public static string Path
        {
            get { return GetParamsValue(Arguments, new string[] { "-p", "-path" }); }
        }
        public static string Version
        {
            get { return GetParamsValue(Arguments, new string[] { "-v", "-ver" }); }
        }
        public static string AppKeyName
        {
            get { return GetParamsValue(Arguments, new string[] { "-akn", "", "-appKeyName" }); }
        }
        public static string Password
        {
            get { return GetParamsValue(Arguments, new string[] { "-pwd", "-password" }); }
        }

        static void Main(string[] args)
        {
            var header = $" Vendstor Shell [ Id : { Constants.SoftwareId }, Version { Constants.Version }, Build : { Constants.Build }  ]  {Environment.NewLine}" +
                        $" (c) RigleSoft - Franz Nkemaka. All Rights Reserved {Environment.NewLine} ";
            Util.WriteLine(header, ConsoleColor.White);

            Arguments = args;
            var app = App;

            if (HasArguments(args))
            {
                SetCurrentTask(Task);
                switch (CurrentTask)
                {
                    case RequestTask.Install:
                        Manager.Install(app, AppKeyName, Source, Path);
                        break;

                    case RequestTask.Update:
                        Manager.Update(app, Source, Path, AppKeyName);
                        break;

                    case RequestTask.Uninstall:
                        Manager.Uninstall(AppKeyName, Path);
                        break;

                    default:
                        HandleArguments(args);
                        break;
                }

                Util.WriteLine($"{ Environment.NewLine} You are free to close this window to continue.", ConsoleColor.Cyan);
            }
            else
            {
                Util.WriteLine("No Task given or invalid Task, use--help to see the task list.", ConsoleColor.Red);
                Console.ReadLine();
            }
        }

        static void HandleArguments(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i] == "--help")
                {
                    var n = Environment.NewLine;
                    var msg = $" Use the following tasks to manage a Vendstor Program : {n} " +
                              $" install : [args] required {n}  update : [args] required  {n}  uninstall : [args] required ";
                    Util.WriteLine(msg, ConsoleColor.DarkCyan);
                    Console.ReadLine();
                }
            }
        }

        static string GetParamValue(string[] args, string param)
        {
            return GetParamsValue(args, new string[] { param });
        }

        static string GetParamsValue(string[] args, string[] _params)
        {
            for (int i = 0; i < args.Length; i++)
            {
                foreach (var param in _params)
                {
                    if (args[i] == param)
                        return args[i + 1];
                }
            }
            return null;
        }

        static bool HasArguments(string[] args, int index = 0)
        {
            if (args == null)
                return false;
            else
                return (index < args.Length);
        }

        static string GetArgument(string[] args, int index)
        {
            // Check if Arguments has index
            if (HasArguments(args, index))
                return args[index];
            else
                return null;
        }

        static void SetCurrentTask(string task)
        {
            if (task == null)
            {
                CurrentTask = RequestTask.Default;
                return;
            }
            switch (task.ToLower())
            {
                case "install":
                    CurrentTask = RequestTask.Install;
                    break;
                case "update":
                    CurrentTask = RequestTask.Update;
                    break;
                case "uninstall":
                    CurrentTask = RequestTask.Uninstall;
                    break;
                default:
                    CurrentTask = RequestTask.Default;
                    break;
            }
        }
    }
}
