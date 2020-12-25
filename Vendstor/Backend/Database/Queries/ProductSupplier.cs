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
    /// Manage Supplier
    /// </summary>
    public class ProductSupplier : Query
    {
        /// <summary>
        /// Checks if Id is valid
        /// </summary>       
        /// <returns></returns>
        public bool IsValid(Objects.ProductSupplier supplier)
        {
            bool isValid;
            try
            {
                //Open Connection
                Database.Connection.Open();

                string query = "SELECT SupplierId FROM ProductSuppliers WHERE SupplierId=@SupplierId";
                MySqlCommand Command = new MySqlCommand(query, Database.Connection);
                Command.Parameters.AddWithValue("SupplierId", supplier.Id);
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
                Logger.QueryError(e, "ProductSupplier", "Verifying Id");
                isValid = false;
            }

            //Close Connection if Open
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            return isValid;
        }

        /// <summary>
        /// Create a new Supplier
        /// </summary>
        /// <returns></returns>
        public Response Create(Objects.ProductSupplier supplier)
        {
            //Props
            int statusCode = 201;
            Response response = new Response();

            //Random Tokens
            supplier.Id = ServerUtil.GenerateToken(TokenLengths.TokensLength);
            try
            {
                Database.Connection.Open();

                string query = " INSERT INTO ProductSuppliers (SupplierId, Name, Markup, Description, FirstName, LastName, Company, " +
                                    " Email, PhoneNumber, Website, Address, PostCode, City, Country  ) " +
                               "  VALUES (@SupplierId, @Name, @Markup, @Description, @FirstName, @LastName, @Company, " +
                               "  @Email, @PhoneNumber, @Website, @Address, @PostCode, @City, @Country  ) ";

                MySqlCommand Command = new MySqlCommand(query, Database.Connection);

                Command.Parameters.AddWithValue("SupplierId", supplier.Id);
                Command.Parameters.AddWithValue("Name", supplier.Name);
                Command.Parameters.AddWithValue("Markup", supplier.Markup);
                Command.Parameters.AddWithValue("Description", supplier.Description);
                Command.Parameters.AddWithValue("FirstName", supplier.FirstName);
                Command.Parameters.AddWithValue("LastName", supplier.LastName);
                Command.Parameters.AddWithValue("Company", supplier.Company);
                Command.Parameters.AddWithValue("Email", supplier.Email);
                Command.Parameters.AddWithValue("PhoneNumber", supplier.PhoneNumber);
                Command.Parameters.AddWithValue("Website", supplier.Website);
                Command.Parameters.AddWithValue("Address", supplier.Address);
                Command.Parameters.AddWithValue("PostCode", supplier.PostCode);
                Command.Parameters.AddWithValue("City", supplier.City);
                Command.Parameters.AddWithValue("Country", supplier.Country);

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
                Logger.QueryError(e, "ProductSupplier", "Create");

            }
            //Close Connection if Open
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            //Response

            response.StatusCode = statusCode;
            response.Data = supplier;

            return response;
        }

        /// <summary>
        /// Get Supplier By Id 
        /// </summary>
        /// <returns></returns>
        public static Objects.ProductSupplier GetSupplier(string supplierId)
        {
            var supplier = new Objects.ProductSupplier();
            try
            {
                if (Database.Connection.State != ConnectionState.Open)
                    Database.Connection.Open();
                var query = "SELECT * FROM ProductSuppliers WHERE SupplierId=@SupplierId";

                MySqlCommand Command = new MySqlCommand(query, Database.Connection);
                Command.Parameters.AddWithValue("SupplierId", supplierId);
                MySqlDataReader DataReader = Command.ExecuteReader();

                while (DataReader.Read())
                {
                    supplier = new Objects.ProductSupplier
                    {
                        Id = DataReader["SupplierId"].ToString(),
                        Name = DataReader["Name"].ToString(),
                        Description = DataReader["Description"].ToString(),
                        FirstName = DataReader["FirstName"].ToString(),
                        LastName = DataReader["LastName"].ToString(),
                        Company = DataReader["Company"].ToString(),
                        Email = DataReader["Email"].ToString(),
                        PhoneNumber = DataReader["PhoneNumber"].ToString(),
                        Website = DataReader["Website"].ToString(),
                        Address = DataReader["Address"].ToString(),
                        PostCode = DataReader["PostCode"].ToString(),
                        City = DataReader["City"].ToString(),
                        Country = DataReader["Country"].ToString(),

                        Markup = decimal.Parse(DataReader["Markup"].ToString()),
                        UpdatedAt = Convert.ToDateTime(DataReader["UpdatedAt"].ToString()),
                        CreatedAt = Convert.ToDateTime(DataReader["CreatedAt"].ToString()),
                    };
                }

                //Close Connection
                Database.Connection.Close();
            }
            catch (MySqlException e)
            {
                Logger.QueryError(e, "ProductSupplier", "GetSupplier");
            }
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            return supplier;
        }

        /// <summary>
        /// Get 
        /// </summary>
        /// <returns></returns>
        public Response Get(Objects.ProductSupplier supplier)
        {
            int statusCode = 200;
            Response response = new Response();
            try
            {
                Database.Connection.Open();

                string Query = "SELECT * FROM ProductSuppliers WHERE SupplierId=@SupplierId";

                //Execute Query 
                MySqlCommand Command = new MySqlCommand(Query, Database.Connection);
                Command.Parameters.AddWithValue("SupplierId", supplier.Id);
                MySqlDataReader DataReader = Command.ExecuteReader();

                //Read Data
                while (DataReader.Read())
                {
                    supplier.Id = DataReader["SupplierId"].ToString();
                    supplier.Name = DataReader["Name"].ToString();
                    supplier.Description = DataReader["Description"].ToString();
                    supplier.FirstName = DataReader["FirstName"].ToString();
                    supplier.LastName = DataReader["LastName"].ToString();
                    supplier.Company = DataReader["Company"].ToString();
                    supplier.Email = DataReader["Email"].ToString();
                    supplier.PhoneNumber = DataReader["PhoneNumber"].ToString();
                    supplier.Website = DataReader["Website"].ToString();
                    supplier.Address = DataReader["Address"].ToString();
                    supplier.PostCode = DataReader["PostCode"].ToString();
                    supplier.City = DataReader["City"].ToString();
                    supplier.Country = DataReader["Country"].ToString();

                    supplier.Markup = decimal.Parse(DataReader["Markup"].ToString());
                    supplier.UpdatedAt = Convert.ToDateTime(DataReader["UpdatedAt"].ToString());
                    supplier.CreatedAt = Convert.ToDateTime(DataReader["CreatedAt"].ToString());
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
                response.Data = supplier;
            }
            catch (MySqlException e)
            {
                Logger.QueryError(e, "ProductSupplier", "Get");
                // Internal Error :
                response.StatusCode = 500;
            }
            //Close Connection if Open
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            return response;
        }

        /// <summary>
        /// Get Suppliers
        /// </summary>
        /// <returns></returns>
        public Response GetSuppliers()
        {
            int statusCode = 200;
            Response response = new Response();
            List<object> suppliers = new List<object>();
            try
            {
                Database.Connection.Open();

                string query = " SELECT DISTINCT ProductSuppliers.*, " +
                               " (SELECT COUNT(*)  FROM Products WHERE Products.SupplierId = ProductSuppliers.SupplierId ) " +
                               " AS ProductsCount " +
                               " FROM ProductSuppliers LEFT OUTER JOIN Products " +
                               " ON ( (SELECT COUNT(*) FROM Products) != 0)" +
                               " ORDER BY ProductsCount DESC ";

                //Execute Query 
                MySqlCommand Command = new MySqlCommand(query, Database.Connection);
                MySqlDataReader DataReader = Command.ExecuteReader();

                //Read Data
                while (DataReader.Read())
                {
                    Objects.ProductSupplier supplier = new Objects.ProductSupplier
                    {
                        Id = DataReader["SupplierId"].ToString(),
                        Name = DataReader["Name"].ToString(),
                        Description = DataReader["Description"].ToString(),
                        FirstName = DataReader["FirstName"].ToString(),
                        LastName = DataReader["LastName"].ToString(),
                        Company = DataReader["Company"].ToString(),
                        Email = DataReader["Email"].ToString(),
                        PhoneNumber = DataReader["PhoneNumber"].ToString(),
                        Website = DataReader["Website"].ToString(),
                        Address = DataReader["Address"].ToString(),
                        PostCode = DataReader["PostCode"].ToString(),
                        City = DataReader["City"].ToString(),
                        Country = DataReader["Country"].ToString(),

                        Markup = decimal.Parse(DataReader["Markup"].ToString()),
                        UpdatedAt = Convert.ToDateTime(DataReader["UpdatedAt"].ToString()),
                        CreatedAt = Convert.ToDateTime(DataReader["CreatedAt"].ToString()),

                        ProductsCount = Convert.ToDouble(DataReader["ProductsCount"].ToString()),
                    };

                    suppliers.Add(supplier);
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
                response.DataArray = suppliers;
            }
            catch (MySqlException e)
            {
                Logger.QueryError(e, "ProductSupplier", "Getting Suppliers");
                // Internal Error :
                response.StatusCode = 500;
            }
            //Close Connection if Open
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            return response;
        }

        public static string GetIdByName(string supplierName)
        {
            string supplierId = null;
            try
            {
                Database.Connection.Open();
                string query = " SELECT SupplierId FROM ProductSuppliers WHERE Name=@Name LIMIT 1";
                //Execute Query 
                MySqlCommand Command = new MySqlCommand(query, Database.Connection);
                Command.Parameters.AddWithValue("Name", supplierName);
                MySqlDataReader DataReader = Command.ExecuteReader();
                //Read Data
                while (DataReader.Read())
                    supplierId = DataReader["SupplierId"].ToString();
                Database.Connection.Close();
            }
            catch (MySqlException e)
            {
                Logger.QueryError(e, "ProductSupplier", "GetIdByName");
            }
            return supplierId;
        }

        /// <summary>
        ///  Update 
        public Response Update(Objects.ProductSupplier supplier)
        {
            int statusCode = 200;
            Response response = new Response();
            try
            {
                Database.Connection.Open();

                string query = " UPDATE ProductSuppliers " +
                               " SET Name=@Name, Markup=@Markup, Description=@Description, FirstName=@FirstName, LastName=@LastName, Company=@Company, Email=@Email," +
                                   " PhoneNumber=@PhoneNumber, Website=@Website, Address=@Address, PostCode=@PostCode, City=@City, Country=@Country " +
                               " WHERE SupplierId=@SupplierId ";
                MySqlCommand Command = new MySqlCommand(query, Database.Connection);

                Command.Parameters.AddWithValue("SupplierId", supplier.Id);
                Command.Parameters.AddWithValue("Name", supplier.Name);
                Command.Parameters.AddWithValue("Markup", supplier.Markup);
                Command.Parameters.AddWithValue("Description", supplier.Description);
                Command.Parameters.AddWithValue("FirstName", supplier.FirstName);
                Command.Parameters.AddWithValue("LastName", supplier.LastName);
                Command.Parameters.AddWithValue("Company", supplier.Company);
                Command.Parameters.AddWithValue("Email", supplier.Email);
                Command.Parameters.AddWithValue("PhoneNumber", supplier.PhoneNumber);
                Command.Parameters.AddWithValue("Website", supplier.Website);
                Command.Parameters.AddWithValue("Address", supplier.Address);
                Command.Parameters.AddWithValue("PostCode", supplier.PostCode);
                Command.Parameters.AddWithValue("City", supplier.City);
                Command.Parameters.AddWithValue("Country", supplier.Country);
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

                Logger.QueryError(e, "ProductSupplier", "Update");
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
        public Response Delete(Objects.ProductSupplier supplier)
        {
            //Props
            int statusCode = 204;
            Response response = new Response();
            try
            {
                Database.Connection.Open();

                string Query = "DELETE FROM ProductSuppliers WHERE SupplierId=@SupplierId ";
                //Execute Query With Connection  => DataReader
                MySqlCommand Command = new MySqlCommand(Query, Database.Connection);
                Command.Parameters.AddWithValue("SupplierId", supplier.Id);

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
                Logger.QueryError(e, "ProductSupplier", "Delete ");
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
