using System;
using System.IO;
using MySql.Data.MySqlClient;

namespace Vendstor.Backend
{
    public static class Logger
    {
        // Paths
        private static readonly string LogFolder = string.Format("C:/Users/{0}/AppData/Local/RigleSoft/{1}/Logs/",
            Environment.UserName, "Vendstor");
        private static readonly string DateTimeStringFormat = "";
        public enum LogType { Info, Success, Warn, Error, Debug }

        #region Constructors

        static Logger()
        {
            var folder = LogFolder.Remove(LogFolder.Length - 1, 1) + "/";

            //Create if Not Exists Logs Folder
            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);

            //Create Files If Not Exists
            CreateFiles();
        }

        private static void CreateFiles()
        {
            //Create Files If Not Exists
            var logFile = $@"{ LogFolder}Vendstor.log";
            var debuggerFile = $@"{ LogFolder}Vendstor.debugger";
            var debugFile = $@"{ LogFolder}Vendstor.debug";
            if (!File.Exists(logFile))
                File.Create(logFile).Dispose();

            if (!File.Exists(debuggerFile))
                File.Create(debuggerFile).Dispose();

            if (!File.Exists(debugFile))
                File.Create(debugFile).Dispose();
            
        }

        #endregion

        /// <summary>
        /// Adds a Database Exception Log
        /// </summary>
        /// <param name="form"></param>
        /// <param name="mySqlException"></param>
        /// <param name="action"></param>
        public static void QueryError(MySqlException exception, string stackClass, string stackMethod)
        {
            string logText = GetLogWithException(exception, exception.Number, stackClass, stackMethod, isDatabase: true);
            string debugText = GetDebugWithException(null, exception, LogType.Error);
            debugText += GetDebugWithException(null, exception.InnerException, LogType.Error);

            WriteToFile(logText, "Vendstor.log");
            WriteToFile(debugText, "Vendstor.debug");
        }

        /// <summary>
        /// Add an Error with an error code
        /// </summary>
        /// <param name="errorCode"></param>
        /// <param name="formName"></param>
        /// <param name="subForm"></param>
        /// <param name="e"></param>
        public static void Error(Exception exception, int statusCode, string stackClass, string stackMethod)
        {
            string logText = GetLogWithException(exception, statusCode, stackClass, stackMethod);
            string debugText = GetDebugWithException(null, exception, LogType.Error);

            if (exception is MySqlException)
                debugText += GetDebugWithException(null, exception.InnerException, LogType.Error);

            WriteToFile(logText, "Vendstor.log");
            WriteToFile(debugText, "Vendstor.debug");
        }

        /// <summary>
        /// Log 
        /// </summary>
        /// <param name="log"> what happened ? </param>
        /// <param name="formName"> where ? </param>
        /// <param name="subForm"> doing what ? </param>
        /// <param name="e"> Eception </param>
        public static void Log(string message, string className = null, string methodName = null, string statusCode = null, LogType logType = LogType.Error)
        {
            var log = GetLog(message, className, methodName, statusCode, logType);
            WriteToFile(log, "Vendstor.log");
        }

        /// <summary>
        /// Returns Message
        /// </summary>
        /// <param name="errorCode"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private static string GetErrorMessage(int errorCode, Exception e = null)
        {
            if (e != null)
                return e.Message;
            string msg = null;

            switch (errorCode)
            {
                case 100:
                    msg = "ERROR 1";
                    break;
            }

            return $" : { msg} ";
        }

        private static string GetLog(string message, string className = null, string methodName = null, string statusCode = null, LogType logType = LogType.Error)
        {
            var _className = className != null ? className + ":" : null;
            var _methodName = methodName != null ? methodName + ":" : null;
            var _statusCode = statusCode != null ? ": " + statusCode : null;
            var log = string.Format("{0} :> {1} {2} Internal :> {3} {4} {5} {6}",
                DateTime.Now.ToString(DateTimeStringFormat), GetLogType(logType), _statusCode + " : " ?? null,
                _className, _methodName, message, Environment.NewLine);

            return log;
        }

        private static string GetLogWithException(Exception exception, int statusCode, string className, string methodName, string message = null, bool isDatabase = false, LogType logType = LogType.Error)
        {
            string typeText = isDatabase ? "Database" : "Internal";
            string _message = exception.Message ?? message + " : INNER : " + exception.Message;
            string log = string.Format("{0} :> {1} : {2} : {3} :> {4}: {5}: {6} {7}",
             DateTime.Now.ToString(DateTimeStringFormat), GetLogType(logType), statusCode, typeText, className, methodName, _message, Environment.NewLine);

            return log;
        }

        private static string GetDebugWithException(string _log, Exception exception, LogType logType)
        {
            var spaceEnd = Environment.NewLine + Environment.NewLine + Environment.NewLine;
            var _message = exception != null ? exception.ToString() : _log;
            var log = string.Format("{0} :> {1} : Internal Or Database :> {2} {3} :: {4}",
             DateTime.Now.ToString(DateTimeStringFormat), GetLogType(logType), _log, Environment.NewLine + _message, spaceEnd);

            return log;
        }

        private static string GetLogType(LogType logType)
        {
            switch (logType)
            {
                case LogType.Success:
                    return "SUCCESS";
                case LogType.Info:
                    return "INFO";
                case LogType.Debug:
                    return "DEBUG";
                case LogType.Warn:
                    return "WARN";
                case LogType.Error:
                    return "ERROR";
                default:
                    return "ERROR";
            }
        }

        /// <summary>
        /// Writes Log in a file
        /// </summary>
        /// <param name="text"> what to write ? </param>
        /// <param name="logFilePath"> Which file ? </param>
        private static void WriteToFile(string text, string logFilePath = "Vendstor.log")
        {
            logFilePath = LogFolder + logFilePath;
            
            //Add Log && Create File If Not Exist
            File.AppendAllText(logFilePath, text);

            /*using (StreamWriter streamWriter = new StreamWriter(logFilePath))
            {
                //streamWriter.WriteLine(text);
            }*/
        }

        /// <summary>
        /// Delete Log File
        /// </summary>
        /// <param name="logFile"> File to Delete </param>
        public static void Delete(string logFile = "Vendstor.log")
        {
            //File Path
            string logFilePath = $"{LogFolder}{logFile}";

            //Delete Log
            File.Delete(logFilePath);
        }

        /// <summary>
        /// Empty Log File
        /// </summary>
        /// <param name="logFile"> File to Empty </param>
        private static void Empty(string logFile = "Vendstor.log")
        {
            //File Path
            string logFilePath = $"{LogFolder}{logFile}";

            //Empty Log
            File.WriteAllText(logFilePath, null);
        }

    }
}
