using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

//Vendstor
using Vendstor.Backend.Utils;
using Vendstor.Backend.Database;

namespace Vendstor.Backend.Server
{
    public class FileTransfer : Connection
    {
        public class File : FileTransfer
        {
            /// <summary>
            /// This is the server folder where you want to upload your content
            /// </summary>
            internal static readonly string ServerFolderUrl = "YOUR_FOLDER_GOES_HERE"; // ex. //var/www/rigle/vendstor/uploads
            /// <summary>
            /// Upload File => returns folder/token.extension as Response
            /// </summary>
            /// <returns></returns>
            public static Response Upload(Objects.File file)
            {
                int statusCode = 200;
                Response response = new Response();
                try
                {
                    //Get Paths
                    var fileName = $@"{ ( (!file.UseCustomName) ? ServerUtil.GenerateToken(10) : file.SaveName ) }{ file.Extension }";
                    var serverAddress = $@"{ftpServerPath}{ file.ServerFolder }{ fileName }";

                    //Create Request
                    ftpWebRequest = WebRequest.Create(new Uri(string.Format(serverAddress))) as FtpWebRequest;
                    ftpWebRequest.Credentials = new NetworkCredential(ftpUsername, ftpPassword);
                    ftpWebRequest.Method = WebRequestMethods.Ftp.UploadFile;

                    ftpWebRequest.UseBinary = true;
                    ftpWebRequest.UsePassive = true;
                    ftpWebRequest.KeepAlive = false;

                    using (FileStream fileStream = System.IO.File.OpenRead(file.SystemFileName))
                    {
                        //Request Stream 
                        Stream ftpRequestStream = ftpWebRequest.GetRequestStream();
                        fileStream.CopyTo(ftpRequestStream);
                        ftpRequestStream.Close();
                    }

                    // OK, Accepted 
                    statusCode = 200;

                    //Send Path Without Server Domain Name
                    file.Path = serverAddress.Replace(ftpServerPath, "").Replace(ServerFolderUrl, "");
                    file.FullPath = serverAddress.Replace("ftp", "http").Replace(ServerFolderUrl, "/");

                    response.Data = file;
                    response.StatusCode = statusCode;
                }

                catch (WebException e)
                {
                    FtpWebResponse ftpWebResponse = (FtpWebResponse)e.Response;
                    if (ftpWebResponse.StatusCode == FtpStatusCode.ActionNotTakenFileUnavailable)
                    {
                        ftpWebResponse.Close();
                        Logger.Error(e, 500, "FileTransfer", "Upload");
                    }
                    else
                        ftpWebResponse.Close();
                }
                catch (Exception e)
                {
                    //[HTTP Status Code] Internal Server Error                 
                    response.StatusCode = 500;
                    Logger.Error(e, 500, "FileTransfer", "Upload");
                }

                return response;
            }

            /// <summary>
            /// Deletes a File from the Server
            /// </summary>
            /// <returns></returns>
            public static Response Delete(Objects.File file)
            {
                Response response = new Response();
                try
                {
                    //Get Paths            
                    var serverAddress = $@"{ftpServerPath}{ file.Path }";

                    // Get the object used to communicate with the server.
                    FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(serverAddress);
                    ftpWebRequest.Credentials = new NetworkCredential(ftpUsername, ftpPassword);

                    //Delete File
                    ftpWebRequest.Method = WebRequestMethods.Ftp.DeleteFile;

                    FtpWebResponse ftpWebResponse = (FtpWebResponse)ftpWebRequest.GetResponse();
                    var status = string.Format("Delete status: {0}", ftpWebResponse.StatusDescription);
                    Logger.Log(status, "FileTransfer", "Delete", null, Logger.LogType.Info);
                    ftpWebResponse.Close();

                    // OK / Accepted
                    response.StatusCode = 200;
                }

                catch (WebException e)
                {
                    FtpWebResponse ftpWebResponse = (FtpWebResponse)e.Response;
                    if (ftpWebResponse.StatusCode == FtpStatusCode.ActionNotTakenFileUnavailable)
                    {
                        ftpWebResponse.Close();
                        Logger.Error(e, 500, "FileTransfer", "Delete");
                    }
                    else
                        ftpWebResponse.Close();
                }
                catch (Exception e)
                {
                    // Internal Server Error                     
                    response.StatusCode = 500;
                    Logger.Error(e, 500, "FileTransfer", "Delete");
                }

                return response;
            }
        }

    }
}
