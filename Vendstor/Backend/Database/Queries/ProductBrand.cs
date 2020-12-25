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
    public class ProductBrand : Query
    {
        /// <summary>
        /// Checks if Id is valid
        /// </summary>       
        /// <returns></returns>
        public bool IsValid(Objects.ProductBrand brand)
        {
            bool isValid;
            try
            {
                //Open Connection
                Database.Connection.Open();

                string query = "SELECT BrandId FROM ProductBrands WHERE BrandId=@BrandId";
                MySqlCommand Command = new MySqlCommand(query, Database.Connection);
                Command.Parameters.AddWithValue("BrandId", brand.Id);
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
                Logger.QueryError(e, "ProductBrand", "Verifying Id");
                isValid = false;
            }

            //Close Connection if Open
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            return isValid;
        }

        /// <summary>
        /// Create a new Brand
        /// </summary>
        /// <returns></returns>
        public Response Create(Objects.ProductBrand brand)
        {
            //Props
            int statusCode = 201;
            Response response = new Response();

            //Random Tokens
            brand.Id = ServerUtil.GenerateToken(TokenLengths.TokensLength);
            try
            {
                Database.Connection.Open();

                string query = "INSERT INTO ProductBrands (BrandId, Name, Description ) VALUES (@BrandId, @Name, @Description) ";
                MySqlCommand Command = new MySqlCommand(query, Database.Connection);

                Command.Parameters.AddWithValue("BrandId", brand.Id);
                Command.Parameters.AddWithValue("Name", brand.Name);
                Command.Parameters.AddWithValue("Description", brand.Description);

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
                Logger.QueryError(e, "ProductBrand", "Create");

            }
            //Close Connection if Open
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            //Response

            response.StatusCode = statusCode;
            response.Data = brand;

            return response;
        }

        /// <summary>
        /// Get Brand By Id 
        /// </summary>
        /// <returns></returns>
        public static Objects.ProductBrand GetBrand(string brandId)
        {
            var brand = new Objects.ProductBrand();
            try
            {
                if (Database.Connection.State != ConnectionState.Open)
                    Database.Connection.Open();
                var query = "SELECT * FROM ProductBrands WHERE BrandId=@BrandId";

                //Execute Query 
                MySqlCommand Command = new MySqlCommand(query, Database.Connection);
                Command.Parameters.AddWithValue("BrandId", brandId);
                MySqlDataReader DataReader = Command.ExecuteReader();

                //Read Data
                while (DataReader.Read())
                {
                    brand = new Objects.ProductBrand
                    {
                        Id = DataReader["BrandId"].ToString(),
                        Name = DataReader["Name"].ToString(),
                        Description = DataReader["Description"].ToString(),
                        UpdatedAt = Convert.ToDateTime(DataReader["UpdatedAt"].ToString()),
                        CreatedAt = Convert.ToDateTime(DataReader["CreatedAt"].ToString())
                    };
                }

                //Close Connection
                Database.Connection.Close();
            }
            catch (MySqlException e)
            {
                Logger.QueryError(e, "ProductBrand", "GetBrand");
            }
            //Close Connection if Open
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            return brand;
        }

        /// <summary>
        /// Get 
        /// </summary>
        /// <returns></returns>
        public Response Get(Objects.ProductBrand brand)
        {
            //Props
            int statusCode = 200;
            Response response = new Response();
            try
            {
                Database.Connection.Open();

                string Query = "SELECT * FROM ProductBrands WHERE BrandId=@BrandId";

                //Execute Query 
                MySqlCommand Command = new MySqlCommand(Query, Database.Connection);
                Command.Parameters.AddWithValue("BrandId", brand.Id);
                MySqlDataReader DataReader = Command.ExecuteReader();

                //Read Data
                while (DataReader.Read())
                {
                    brand.Id = DataReader["BrandId"].ToString();
                    brand.Name = DataReader["Name"].ToString();
                    brand.Description = DataReader["Description"].ToString();

                    brand.UpdatedAt = Convert.ToDateTime(DataReader["UpdatedAt"].ToString());
                    brand.CreatedAt = Convert.ToDateTime(DataReader["CreatedAt"].ToString());
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
                response.Data = brand;
            }
            catch (MySqlException e)
            {
                Logger.QueryError(e, "ProductBrand", "Get");
                // Internal Error :
                response.StatusCode = 500;
            }
            //Close Connection if Open
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            return response;
        }

        /// <summary>
        /// Get Brands
        /// </summary>
        /// <returns></returns>
        public Response GetBrands()
        {
            //Props
            int statusCode = 200;
            Response response = new Response();
            List<object> brands = new List<object>();
            try
            {
                Database.Connection.Open();

                string query = " SELECT DISTINCT ProductBrands.*, " +
                               " (SELECT COUNT(*)  FROM Products WHERE Products.BrandId = ProductBrands.BrandId ) " +
                               " AS ProductsCount " +
                               " FROM ProductBrands LEFT OUTER JOIN Products " +
                               " ON ( (SELECT COUNT(*) FROM Products) != 0)" +
                               " ORDER BY ProductsCount DESC ";

                //Execute Query 
                MySqlCommand Command = new MySqlCommand(query, Database.Connection);
                MySqlDataReader DataReader = Command.ExecuteReader();

                //Read Data
                while (DataReader.Read())
                {
                    Objects.ProductBrand brand = new Objects.ProductBrand
                    {
                        Id = DataReader["BrandId"].ToString(),
                        Name = DataReader["Name"].ToString(),
                        Description = DataReader["Description"].ToString(),

                        ProductsCount = Convert.ToDouble(DataReader["ProductsCount"].ToString()),

                        UpdatedAt = Convert.ToDateTime(DataReader["UpdatedAt"].ToString()),
                        CreatedAt = Convert.ToDateTime(DataReader["CreatedAt"].ToString()),
                    };

                    brands.Add(brand);
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
                response.DataArray = brands;
            }
            catch (MySqlException e)
            {
                Logger.QueryError(e, "ProductBrand", "Getting Brands");
                // Internal Error :
                response.StatusCode = 500;
            }
            //Close Connection if Open
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            return response;
        }
        
        public static string GetIdByName(string brandName)
        {
            string brandId = null;
            try
            {
                Database.Connection.Open();
                string query = " SELECT BrandId FROM ProductBrands WHERE Name=@Name LIMIT 1";
                //Execute Query 
                MySqlCommand Command = new MySqlCommand(query, Database.Connection);
                Command.Parameters.AddWithValue("Name", brandName);
                MySqlDataReader DataReader = Command.ExecuteReader();
                //Read Data
                while (DataReader.Read())
                    brandId = DataReader["BrandId"].ToString();
                Database.Connection.Close();
            }
            catch (MySqlException e)
            {
                Logger.QueryError(e, "ProductBrand", "GetIdByName");
            }
            return brandId;
        }

        /// <summary>
        ///  Update 
        public Response Update(Objects.ProductBrand brand)
        {
            //Props
            int statusCode = 200;
            Response response = new Response();
            try
            {
                Database.Connection.Open();

                string query = "UPDATE ProductBrands SET Name=@Name, Description=@Description WHERE BrandId=@BrandId ";
                MySqlCommand Command = new MySqlCommand(query, Database.Connection);

                Command.Parameters.AddWithValue("BrandId", brand.Id);
                Command.Parameters.AddWithValue("Name", brand.Name);
                Command.Parameters.AddWithValue("Description", brand.Description);

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

                Logger.QueryError(e, "ProductBrand", "Update");
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
        public Response Delete(Objects.ProductBrand brand)
        {
            //Props
            int statusCode = 204;
            Response response = new Response();
            try
            {
                Database.Connection.Open();

                string Query = "DELETE FROM ProductBrands WHERE BrandId=@BrandId ";
                //Execute Query With Connection  => DataReader
                MySqlCommand Command = new MySqlCommand(Query, Database.Connection);
                Command.Parameters.AddWithValue("BrandId", brand.Id);

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
                Logger.QueryError(e, "ProductBrand", "Delete ");
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
