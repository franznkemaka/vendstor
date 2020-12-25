using System;
using System.Net;

//Vendstor

namespace Vendstor.Backend.Server
{
    public class Connection
    {
        //Default serverCredentials
        internal static readonly string ftpUsername = "YOUR_FTP_USERNAME";
        internal static readonly string ftpPassword = "YOUR_FTP_PASSWORD";
        internal static readonly string ftpPort = "YOUR_FTP_PORT";
        internal static readonly string ftpServerPath = "YOUR_FTP_PATH_TO_UPLOAD_TO"; // ex. ftp://vendstor.rigle.co//var/www/rigle/vendstor/uploads
        internal static FtpWebRequest ftpWebRequest;
    }
}
