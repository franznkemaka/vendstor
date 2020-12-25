using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Data;

// Vendstor
using Vendstor.Backend.Utils;
using Vendstor.Backend.Server;
using Vendstor.Backend.Constants;
namespace Vendstor.Backend.Database.Queries
{
    /// <summary>
    /// Manage Blobs : Create, Delete
    /// </summary>
    public class Blob : Query
    {
        /// <summary>
        /// Upload file to server and save to db & return blobId
        /// </summary>
        public Response Create(Objects.File file)
        {
            int statusCode = 200;
            var blobId = ServerUtil.GenerateToken(TokenLengths.BlobIdLength);
            Response response = new Response();
            try
            {
                var res = FileTransfer.File.Upload(file);
                if (res.StatusCode != 200)
                {
                    statusCode = res.StatusCode;
                    throw new Exception("Error Occured while Uploading File");
                }
                var _file = (Objects.File)res.Data;

                file.Path = _file.Path;
                file.FullPath = _file.FullPath;

                //Open MySqlConnection
                Database.Connection.Open();
                var query = "INSERT INTO Blobs (BlobId, Path, Url) VALUES (@BlobId, @Path, @Url)";

                //Execute Query With MySqlConnection
                MySqlCommand Command = new MySqlCommand(query, Database.Connection);
                Command.Parameters.AddWithValue("BlobId", blobId);
                Command.Parameters.AddWithValue("Path", file.Path);
                Command.Parameters.AddWithValue("Url", file.FullPath);
                Command.ExecuteNonQuery();

                //Close Connection
                Database.Connection.Close();

                // Response
                file.BlobId = blobId;
                response.Data = file;
            }
            catch (Exception e)
            {
                Logger.Error(e, 500, "Blob", "Create");
                statusCode = 500;
            }

            //Close Connection if Open
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            response.StatusCode = statusCode;
            return response;
        }

        /// <summary>
        /// Get file from db
        /// </summary>
        public Response Get(string blobId)
        {
            int statusCode = 200;
            Response response = new Response();
            Objects.File file = new Objects.File();
            try
            {
                //Open MySqlConnection
                Database.Connection.Open();

                //Query
                string Query = "SELECT * FROM Blobs WHERE BlobId=@BlobId";

                //Execute Query 
                MySqlCommand Command = new MySqlCommand(Query, Database.Connection);
                Command.Parameters.AddWithValue("BlobId", blobId);
                MySqlDataReader DataReader = Command.ExecuteReader();

                //Read Data
                while (DataReader.Read())
                {
                    file.Path = DataReader["Path"].ToString();
                    file.FullPath = DataReader["Url"].ToString();
                    file.CreatedAt = Convert.ToDateTime(DataReader["CreatedAt"].ToString());
                }
                if (!DataReader.HasRows)
                    // Bad Request 
                    statusCode = 400;
                else
                    // OK 
                    statusCode = 200;

                //Close Connection
                Database.Connection.Close();

                // Response
                file.BlobId = blobId;
                response.Data = file;
            }
            catch (Exception e)
            {
                Logger.Error(e, 500, "Blob", "Get");
                statusCode = 500;
            }

            //Close Connection if Open
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            response.StatusCode = statusCode;
            return response;
        }

        /// <summary>
        /// Delete file from server and db
        /// </summary>
        public Response Delete(Objects.File file)
        {
            int statusCode = 200;
            Response response = new Response();
            try
            {
                var res = FileTransfer.File.Delete(file);
                if (res.StatusCode != 200)
                {
                    statusCode = res.StatusCode;
                    throw new Exception("Error Occured while Deleting File");
                }

                //Open MySqlConnection
                Database.Connection.Open();
                var query = "DELETE FROM Blobs WHERE BlobId=@BlobId ";

                //Execute Query With MySqlConnection
                MySqlCommand Command = new MySqlCommand(query, Database.Connection);
                Command.Parameters.AddWithValue("BlobId", file.BlobId);
                Command.ExecuteNonQuery();

                //Close Connection
                Database.Connection.Close();

                // Response
                response.Data = file;
            }
            catch (Exception e)
            {
                Logger.Error(e, 500, "Blob", "Delete");
                statusCode = 500;
            }

            //Close Connection if Open
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            response.StatusCode = statusCode;
            return response;
        }
    }
}
