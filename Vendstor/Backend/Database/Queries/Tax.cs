using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Data;

// Vendstor
using Vendstor.Backend.Utils;
using Vendstor.Backend.Constants;

namespace Vendstor.Backend.Database.Queries
{
    /// <summary>
    /// Manage Taxes : Create, Update, Get Data
    /// </summary>
    public class Tax : Query
    {
        /// <summary>
        /// Create a new Store's default Taxes (2)
        /// </summary>
        public bool Create(Objects.Store store = null)
        {
            bool response = false;
            var storeId = store.Id ?? Properties.Settings.Default.StoreId;
            var taxId = ServerUtil.GenerateToken(TokenLengths.TokensLength);
            var _taxId = ServerUtil.GenerateToken(TokenLengths.TokensLength);
            try
            {
                //Open MySqlConnection
                Database.Connection.Open();
                var query1 = "INSERT INTO Taxes (TaxId, StoreId) VALUES (@TaxId, @StoreId)";
                var query2 = "INSERT INTO Taxes (TaxId, StoreId) VALUES (@TaxId, @StoreId)";

                //Execute Query With MySqlConnection
                MySqlCommand Command1 = new MySqlCommand(query1, Database.Connection);
                MySqlCommand Command2 = new MySqlCommand(query2, Database.Connection);
                Command1.Parameters.AddWithValue("TaxId", taxId);
                Command1.Parameters.AddWithValue("StoreId", storeId);
                Command2.Parameters.AddWithValue("TaxId", _taxId);
                Command2.Parameters.AddWithValue("StoreId", storeId);
                Command1.ExecuteNonQuery();
                Command2.ExecuteNonQuery();

                //Close Connection
                Database.Connection.Close();

                return true;
            }
            catch (MySqlException e)
            {
                Logger.QueryError(e, "Tax", "Create");
            }

            //Close Connection if Open
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            return response;
        }

        /// <summary>
        /// Get All Store taxes
        /// </summary>
        /// <param name="store"></param>
        /// <returns></returns>
        public Response GetTaxes(Objects.Store store)
        {
            //Props
            int statusCode = 200;
            store.Id = store.Id ?? Properties.Settings.Default.StoreId;
            Response response = new Response();
            List<object> taxes = new List<object>();
            try
            {
                Database.Connection.Open();
                //Query
                string query = "SELECT * FROM Taxes WHERE StoreId=@StoreId";

                //Execute Query 
                MySqlCommand Command = new MySqlCommand(query, Database.Connection);
                Command.Parameters.AddWithValue("StoreId", store.Id);
                MySqlDataReader DataReader = Command.ExecuteReader();

                //Read Data
                while (DataReader.Read())
                {
                    Objects.Tax tax = new Objects.Tax
                    {
                        Id = DataReader["TaxId"].ToString(),
                        Name = DataReader["Name"].ToString(),
                        Rate = decimal.Parse(DataReader["Rate"].ToString()),
                        ShortName = DataReader["ShortName"].ToString(),
                        StoreShortName = DataReader["StoreShortName"].ToString(),
                        Description = DataReader["Description"].ToString(),
                        UpdatedAt = Convert.ToDateTime(DataReader["UpdatedAt"].ToString()),
                        CreatedAt = Convert.ToDateTime(DataReader["CreatedAt"].ToString())
                    };

                    taxes.Add(tax);
                }
                if (!DataReader.HasRows)
                    // Bad Request 
                    statusCode = 400;
                else
                    // OK 
                    statusCode = 200;

                //Close Connection
                Database.Connection.Close();

                response.StatusCode = statusCode;
                response.DataArray = taxes;
            }
            catch (MySqlException e)
            {
                Logger.QueryError(e, "Taxes", "Getting Taxes");
                response.StatusCode = 500;
            }
            //Close Connection if Open
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            return response;
        }

        /// <summary>
        /// Get Tax 
        /// </summary>
        /// <returns></returns>
        public static Objects.Tax GetTax(string taxId  = null, string taxCode = null)
        { 
            Objects.Tax tax = new Objects.Tax();
            try
            {
                if(Database.Connection.State != ConnectionState.Open)
                    Database.Connection.Open();

                var query = "SELECT * FROM Taxes WHERE (TaxId=@TaxId OR StoreShortName=@TaxCode)";

                MySqlCommand Command = new MySqlCommand(query, Database.Connection);
                Command.Parameters.AddWithValue("TaxId", taxId);
                Command.Parameters.AddWithValue("TaxCode", taxCode);
                MySqlDataReader DataReader = Command.ExecuteReader();

                while (DataReader.Read())
                {
                    tax = new Objects.Tax
                    {
                        Id = DataReader["TaxId"].ToString(),
                        Name = DataReader["Name"].ToString(),
                        Rate = decimal.Parse(DataReader["Rate"].ToString()),
                        ShortName = DataReader["ShortName"].ToString(),
                        StoreShortName = DataReader["StoreShortName"].ToString(),
                        Description = DataReader["Description"].ToString(),
                        UpdatedAt = Convert.ToDateTime(DataReader["UpdatedAt"].ToString()),
                        CreatedAt = Convert.ToDateTime(DataReader["CreatedAt"].ToString())
                    };
                }  

                Database.Connection.Close();
            }
            catch (MySqlException e)
            {
                Logger.QueryError(e, "Taxes", "GetTax");
            }
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            return tax;
        }
        
        public static string GetIdByName(string taxName)
        {
            string taxId = null;
            try
            {
                Database.Connection.Open();
                string query = " SELECT TaxId FROM Taxes WHERE Name=@Name LIMIT 1";
                //Execute Query 
                MySqlCommand Command = new MySqlCommand(query, Database.Connection);
                Command.Parameters.AddWithValue("Name", taxName);
                MySqlDataReader DataReader = Command.ExecuteReader();
                //Read Data
                while (DataReader.Read())
                    taxId = DataReader["TaxId"].ToString();
                Database.Connection.Close();
            }
            catch (MySqlException e)
            {
                Logger.QueryError(e, "Tax", "GetIdByName");
            }
            return taxId;
        }
        
        /// <summary>
        /// Update Tax
        /// </summary>
        /// <returns></returns>
        public Response Update(Objects.Tax tax)
        {
            int statusCode = 204;
            Response response = new Response();
            var storeId = Properties.Settings.Default.StoreId;
            try
            {
                //Open MySqlConnection
                Database.Connection.Open();
                var query = " UPDATE Taxes SET Name=@Name, Rate=@Rate, ShortName=@ShortName, StoreShortName=@StoreShortName, Description=@Description" +
                            " WHERE TaxId=@TaxId AND StoreId=@StoreId";

                //Execute Query With MySqlConnection
                MySqlCommand Command = new MySqlCommand(query, Database.Connection);
                Command.Parameters.AddWithValue("TaxId", tax.Id);
                Command.Parameters.AddWithValue("StoreId", storeId);

                Command.Parameters.AddWithValue("Name", tax.Name);
                Command.Parameters.AddWithValue("Rate", tax.Rate);
                Command.Parameters.AddWithValue("ShortName", tax.ShortName);
                Command.Parameters.AddWithValue("StoreShortName", tax.StoreShortName);
                Command.Parameters.AddWithValue("Description", tax.Description);
                Command.ExecuteNonQuery();

                //Close Connection
                Database.Connection.Close();

                response.StatusCode = 204;
            }
            catch (MySqlException e)
            {
                if (e.Message.Contains("Duplicate entry"))
                    //Duplicate Key or Conflict
                    statusCode = 409;
                else
                    // Internal Server Error
                    statusCode = 500;

                Logger.QueryError(e, "Tax", "Update");
                // Status Code
                response.StatusCode = statusCode;
            }
            //Close Connection if Open
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            return response;
        }
    }
}
