using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Collections.Generic;

// Vendstor
using Vendstor.Backend.Utils;
using Vendstor.Backend.Constants;

/** 
 * Copyright : © RigleSoft™,  Rigle™ - A Company of Franz Nkemaka™ -  All Rights Reserved 
 * Read README for more information. */

namespace Vendstor.Backend.Database.Queries
{
    /// <summary>
    /// Manage Group
    /// </summary>
    public class CustomerGroup
    {
        /// <summary>
        /// Checks if Id is valid
        /// </summary>       
        /// <returns></returns>
        public bool IsValid(Objects.CustomerGroup group)
        {
            bool isValid;
            try
            {
                //Open Connection
                Database.Connection.Open();

                string query = "SELECT GroupId FROM CustomerGroups WHERE GroupId=@GroupId";
                MySqlCommand Command = new MySqlCommand(query, Database.Connection);
                Command.Parameters.AddWithValue("GroupId", group.Id);
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
                Logger.QueryError(e, "CustomerGroup", "Verifying Id");
                isValid = false;
            }

            //Close Connection if Open
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            return isValid;
        }

        /// <summary>
        /// Create a new Group
        /// </summary>
        /// <returns></returns>
        public Response Create(Objects.CustomerGroup group)
        {
            //Props
            int statusCode = 201;
            Response response = new Response();

            //Random Tokens
            group.Id = ServerUtil.GenerateToken(TokenLengths.TokensLength);
            try
            {
                Database.Connection.Open();

                string query = "INSERT INTO CustomerGroups (GroupId, Name ) VALUES (@GroupId, @Name) ";
                MySqlCommand Command = new MySqlCommand(query, Database.Connection);

                Command.Parameters.AddWithValue("GroupId", group.Id);
                Command.Parameters.AddWithValue("Name", group.Name);

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
                Logger.QueryError(e, "CustomerGroup", "Create");

            }
            //Close Connection if Open
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            //Response

            response.StatusCode = statusCode;
            response.Data = group;

            return response;
        }

        /// <summary>
        /// Get 
        /// </summary>
        /// <returns></returns>
        public Response Get(Objects.CustomerGroup group)
        {
            //Props
            int statusCode = 200;
            Response response = new Response();
            try
            {
                Database.Connection.Open();

                string Query = "SELECT * FROM CustomerGroups WHERE GroupId=@GroupId";

                //Execute Query 
                MySqlCommand Command = new MySqlCommand(Query, Database.Connection);
                Command.Parameters.AddWithValue("GroupId", group.Id);
                MySqlDataReader DataReader = Command.ExecuteReader();

                //Read Data
                while (DataReader.Read())
                {
                    group.Id = DataReader["GroupId"].ToString();
                    group.Name = DataReader["Name"].ToString();

                    group.UpdatedAt = Convert.ToDateTime(DataReader["UpdatedAt"].ToString());
                    group.CreatedAt = Convert.ToDateTime(DataReader["CreatedAt"].ToString());
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
                response.Data = group;
            }
            catch (MySqlException e)
            {
                Logger.QueryError(e, "CustomerGroup", "Get");
                // Internal Error :
                response.StatusCode = 500;
            }
            //Close Connection if Open
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            return response;
        }

        /// <summary>
        /// Get Groups
        /// </summary>
        /// <returns></returns>
        public Response GetGroups()
        {
            //Props
            int statusCode = 200;
            Response response = new Response();
            List<object> groups = new List<object>();
            try
            {
                Database.Connection.Open();
                string query = " SELECT DISTINCT CustomerGroups.*, " +
                            " (SELECT COUNT(*)  FROM Customers WHERE Customers.GroupId = CustomerGroups.GroupId ) " +
                            " AS CustomersCount " +
                            " FROM CustomerGroups LEFT OUTER JOIN Customers " +
                            " ON ( (SELECT COUNT(*) FROM Customers) != 0)" +
                            " ORDER BY CustomersCount DESC ";

                //Execute Query 
                MySqlCommand Command = new MySqlCommand(query, Database.Connection);
                MySqlDataReader DataReader = Command.ExecuteReader();

                //Read Data
                while (DataReader.Read())
                {
                    Objects.CustomerGroup group = new Objects.CustomerGroup
                    {
                        Id = DataReader["GroupId"].ToString(),
                        Name = DataReader["Name"].ToString(),

                        CustomersCount = Convert.ToDouble(DataReader["CustomersCount"].ToString()),

                        UpdatedAt = Convert.ToDateTime(DataReader["UpdatedAt"].ToString()),
                        CreatedAt = Convert.ToDateTime(DataReader["CreatedAt"].ToString()),
                    };

                    groups.Add(group);
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
                response.DataArray = groups;
            }
            catch (MySqlException e)
            {
                Logger.QueryError(e, "CustomerGroup", "Getting Groups");
                // Internal Error :
                response.StatusCode = 500;
            }
            //Close Connection if Open
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            return response;
        }

        public string GetGroupId(string groupName)
        {
            string groupId = null;
            try
            {
                Database.Connection.Open();

                string query = " SELECT GroupId FROM CustomerGroups WHERE Name=@Name LIMIT 1";

                //Execute Query 
                MySqlCommand Command = new MySqlCommand(query, Database.Connection);
                Command.Parameters.AddWithValue("Name", groupName);
                MySqlDataReader DataReader = Command.ExecuteReader();

                //Read Data
                while (DataReader.Read())
                    groupId = DataReader["GroupId"].ToString();

                Database.Connection.Close();
            }
            catch (MySqlException e)
            {
                Logger.QueryError(e, "CustomerGroup", "GetGroupId");
            }
            return groupId;
        }

        /// <summary>
        /// Get Customers Count  '''' ### Joined to GetGroups
        /// </summary>
        /// <returns></returns>
        public Response GetCustomerCount(Objects.CustomerGroup group)
        {
            //Props
            int statusCode = 200;
            int customerCount = 0;
            Response response = new Response();
            try
            {
                Database.Connection.Open();
                var query = " SELECT COUNT(*) As CustomerCount FROM Customers WHERE GroupId=@GroupId  ";

                //Execute Query 
                MySqlCommand Command = new MySqlCommand(query, Database.Connection);
                Command.Parameters.AddWithValue("GroupId", group.Id);
                MySqlDataReader DataReader = Command.ExecuteReader();

                //Read Data
                while (DataReader.Read())
                {
                    customerCount = Convert.ToInt32(DataReader["CustomerCount"].ToString());
                }
                Database.Connection.Close();

                //Response 
                response.StatusCode = statusCode;
                response.IntegerData = customerCount;
            }
            catch (MySqlException e)
            {
                Logger.QueryError(e, "CustomerGroup", "GetCustomerCount");
                // Internal Error :
                response.StatusCode = 500;
            }
            //Close Connection if Open
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            return response;
        }

        /// <summary>
        ///  Update 
        public Response Update(Objects.CustomerGroup group)
        {
            //Props
            int statusCode = 200;
            Response response = new Response();
            try
            {
                Database.Connection.Open();

                string query = "UPDATE CustomerGroups SET Name=@Name WHERE GroupId=@GroupId ";
                MySqlCommand Command = new MySqlCommand(query, Database.Connection);

                Command.Parameters.AddWithValue("GroupId", group.Id);
                Command.Parameters.AddWithValue("Name", group.Name);
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

                Logger.QueryError(e, "CustomerGroup", "Update");
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
        public Response Delete(Objects.CustomerGroup group)
        {
            //Props
            int statusCode = 204;
            Response response = new Response();
            try
            {
                Database.Connection.Open();

                string Query = "DELETE FROM CustomerGroups WHERE GroupId=@GroupId ";
                //Execute Query With Connection  => DataReader
                MySqlCommand Command = new MySqlCommand(Query, Database.Connection);
                Command.Parameters.AddWithValue("GroupId", group.Id);

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
                Logger.QueryError(e, "CustomerGroup", "Delete ");
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
