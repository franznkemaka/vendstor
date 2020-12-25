using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Data;

// Vendstor
using Vendstor.Backend.Utils;
using Vendstor.Backend.Constants;

/** 
 * Copyright : © RigleSoft™,  Rigle™ - A Company of Franz Nkemaka™ -  All Rights Reserved 
 * Read README for more information. */

namespace Vendstor.Backend.Database.Queries
{
    /// <summary>
    /// Manage Type
    /// </summary>
    public class ProductType : Query
    {
        /// <summary>
        /// Checks if Id is valid
        /// </summary>       
        /// <returns></returns>
        public bool IsValid(Objects.ProductType type)
        {
            bool isValid;
            try
            {
                //Open Connection
                Database.Connection.Open();

                string query = "SELECT TypeId FROM ProductTypes WHERE TypeId=@TypeId";
                MySqlCommand Command = new MySqlCommand(query, Database.Connection);
                Command.Parameters.AddWithValue("TypeId", type.Id);
                MySqlDataReader DataReader = Command.ExecuteReader();
                if (!DataReader.HasRows)
                    isValid = false;
                else
                    isValid = true;

                //Close Connection
                Database.Connection.Close();
            }
            catch (MySqlException e)
            {
                Logger.QueryError(e, "ProductType", "Verifying Id");
                isValid = false;
            }

            //Close Connection if Open
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            return isValid;
        }
        
        /// <summary>
        /// Create a new Type
        /// </summary>
        /// <returns></returns>
        public Response Create(Objects.ProductType type)
        {
            //Props
            int statusCode = 201;
            Response response = new Response();

            //Random Tokens
            type.Id = ServerUtil.GenerateToken(TokenLengths.TokensLength);
            try
            {
                Database.Connection.Open();

                string query = "INSERT INTO ProductTypes (TypeId, Name ) VALUES (@TypeId, @Name) ";
                MySqlCommand Command = new MySqlCommand(query, Database.Connection);

                Command.Parameters.AddWithValue("TypeId", type.Id);
                Command.Parameters.AddWithValue("Name", type.Name);

                Command.ExecuteNonQuery();

                Database.Connection.Close();

                // Status Code
                statusCode = 201;
            }
            catch (MySqlException e)
            {
                if (e.Message.Contains("Duplicate entry"))
                    //Duplicate Key or Conflict
                    statusCode = 409;
                else
                    // Internal Server Error
                    statusCode = 500;
                Logger.QueryError(e, "ProductType", "Create");

            }
            //Close Connection if Open
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            //Response

            response.StatusCode = statusCode;
            response.Data = type;

            return response;
        }

        /// <summary>
        /// Get Type By Id 
        /// </summary>
        /// <returns></returns>
        public static Objects.ProductType GetTypeById(string typeId)
        {
            var type = new Objects.ProductType();
            try
            {
                if (Database.Connection.State != ConnectionState.Open)
                    Database.Connection.Open();
                var query = "SELECT * FROM ProductTypes WHERE TypeId=@TypeId";

                //Execute Query 
                MySqlCommand Command = new MySqlCommand(query, Database.Connection);
                Command.Parameters.AddWithValue("TypeId", typeId);
                MySqlDataReader DataReader = Command.ExecuteReader();

                //Read Data
                while (DataReader.Read())
                {
                    type = new Objects.ProductType
                    {
                        Id = DataReader["TypeId"].ToString(),
                        Name = DataReader["Name"].ToString(),
                        UpdatedAt = Convert.ToDateTime(DataReader["UpdatedAt"].ToString()),
                        CreatedAt = Convert.ToDateTime(DataReader["CreatedAt"].ToString())
                    };
                }

                //Close Connection
                Database.Connection.Close();
            }
            catch (MySqlException e)
            {
                Logger.QueryError(e, "ProductType", "GetTypeById");
            }
            //Close Connection if Open
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            return type;
        }

        /// <summary>
        /// Get 
        /// </summary>
        /// <returns></returns>
        public Response Get(Objects.ProductType type)
        {
            //Props
            int statusCode = 200;
            Response response = new Response();
            try
            {
                Database.Connection.Open();

                string Query = "SELECT * FROM ProductTypes WHERE TypeId=@TypeId";

                //Execute Query 
                MySqlCommand Command = new MySqlCommand(Query, Database.Connection);
                Command.Parameters.AddWithValue("TypeId", type.Id);
                MySqlDataReader DataReader = Command.ExecuteReader();

                //Read Data
                while (DataReader.Read())
                {
                    type.Id = DataReader["TypeId"].ToString();
                    type.Name = DataReader["Name"].ToString();

                    type.UpdatedAt = Convert.ToDateTime(DataReader["UpdatedAt"].ToString());
                    type.CreatedAt = Convert.ToDateTime(DataReader["CreatedAt"].ToString());
                }
                if (!DataReader.HasRows)
                    // Bad Request 
                    statusCode = 400;
                else
                    // OK 
                    statusCode = 200;

                Database.Connection.Close();

                //Response 
                response.StatusCode = statusCode;
                response.Data = type;
            }
            catch (MySqlException e)
            {
                Logger.QueryError(e, "ProductType", "Get");
                // Internal Error :
                response.StatusCode = 500;
            }
            //Close Connection if Open
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            return response;
        }

        /// <summary>
        /// Get Types
        /// </summary>
        /// <returns></returns>
        public Response GetTypes()
        {
            //Props
            int statusCode = 200;
            Response response = new Response();
            List<object> types = new List<object>();
            try
            {
                Database.Connection.Open();

                string query = " SELECT DISTINCT ProductTypes.*, " +
                               " (SELECT COUNT(*)  FROM Products WHERE Products.TypeId = ProductTypes.TypeId ) " +
                               " AS ProductsCount " +
                               " FROM ProductTypes LEFT OUTER JOIN Products " +
                               " ON ( (SELECT COUNT(*) FROM Products) != 0)" +
                               " ORDER BY ProductsCount DESC ";

                //Execute Query 
                MySqlCommand Command = new MySqlCommand(query, Database.Connection);
                MySqlDataReader DataReader = Command.ExecuteReader();

                //Read Data
                while (DataReader.Read())
                {
                    Objects.ProductType type = new Objects.ProductType
                    {
                        Id = DataReader["TypeId"].ToString(),
                        Name = DataReader["Name"].ToString(),

                        ProductsCount = Convert.ToDouble(DataReader["ProductsCount"].ToString()),

                        UpdatedAt = Convert.ToDateTime(DataReader["UpdatedAt"].ToString()),
                        CreatedAt = Convert.ToDateTime(DataReader["CreatedAt"].ToString()),
                    };

                    types.Add(type);
                }
                if (!DataReader.HasRows)
                    // Nothing
                    statusCode = 204;
                else
                    // OK 
                    statusCode = 200;

                Database.Connection.Close();

                //Response 
                response.StatusCode = statusCode;
                response.DataArray = types;
            }
            catch (MySqlException e)
            {
                Logger.QueryError(e, "ProductType", "Getting Types");
                // Internal Error :
                response.StatusCode = 500;
            }
            //Close Connection if Open
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            return response;
        }

        public static string GetIdByName(string typeName)
        {
            string typeId = null;
            try
            {
                Database.Connection.Open();
                string query = " SELECT TypeId FROM ProductTypes WHERE Name=@Name LIMIT 1";
                //Execute Query 
                MySqlCommand Command = new MySqlCommand(query, Database.Connection);
                Command.Parameters.AddWithValue("Name", typeName);
                MySqlDataReader DataReader = Command.ExecuteReader();
                //Read Data
                while (DataReader.Read())
                    typeId = DataReader["TypeId"].ToString();
                Database.Connection.Close();
            }
            catch (MySqlException e)
            {
                Logger.QueryError(e, "ProductType", "GetIdByName");
            }
            return typeId;
        }

        /// <summary>
        ///  Update 
        public Response Update(Objects.ProductType type)
        {
            //Props
            int statusCode = 200;
            Response response = new Response();
            try
            {
                Database.Connection.Open();

                string query = "UPDATE ProductTypes SET Name=@Name WHERE TypeId=@TypeId ";
                MySqlCommand Command = new MySqlCommand(query, Database.Connection);

                Command.Parameters.AddWithValue("TypeId", type.Id);
                Command.Parameters.AddWithValue("Name", type.Name);
                Command.ExecuteNonQuery();

                Database.Connection.Close();

                // Updated Successfully 
                statusCode = 204;

                //Response 
                response.StatusCode = statusCode;
            }
            catch (MySqlException e)
            {
                if (e.Message.Contains("Duplicate entry"))
                    //Duplicate Key or Conflict
                    statusCode = 409;
                else
                    // Internal Server Error
                    statusCode = 500;

                Logger.QueryError(e, "ProductType", "Update");
                // Status Code
                response.StatusCode = statusCode;
            }
            //Close Connection if Open
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            return response;
        }

        /// <summary>
        ///  Delete 
        /// </summary>
        public Response Delete(Objects.ProductType type)
        {
            //Props
            int statusCode = 204;
            Response response = new Response();
            try
            {
                Database.Connection.Open();

                string Query = "DELETE FROM ProductTypes WHERE TypeId=@TypeId ";
                //Execute Query With Connection  => DataReader
                MySqlCommand Command = new MySqlCommand(Query, Database.Connection);
                Command.Parameters.AddWithValue("TypeId", type.Id);

                //Execute Command
                Command.ExecuteNonQuery();

                //Close Connection
                Database.Connection.Close();

                //[HTTP Status Code] OK : Successfully Deleted : Returning No Content    
                statusCode = 204;
                response.StatusCode = statusCode;
            }
            catch (MySqlException e)
            {
                Logger.QueryError(e, "ProductType", "Delete ");
                // Internal Error :
                response.StatusCode = 500;
            }
            //Close Connection if Open
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            return response;
        }
      
    }
}
