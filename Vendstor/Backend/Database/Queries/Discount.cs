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
    public class Discount : Query
    {
        /// <summary>
        /// Checks if Id is valid
        /// </summary>       
        /// <returns></returns>
        public bool IsValid(Objects.Discount discount)
        {
            bool isValid;
            try
            {
                //Open Connection
                Database.Connection.Open();

                string query = "SELECT DiscountId FROM Discounts WHERE DiscountId=@DiscountId";
                MySqlCommand Command = new MySqlCommand(query, Database.Connection);
                Command.Parameters.AddWithValue("DiscountId", discount.Id);
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
                Logger.QueryError(e, "Discount", "Verifying Id");
                isValid = false;
            }

            //Close Connection if Open
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            return isValid;
        }

        /// <summary>
        /// Create a new Discount
        /// </summary>
        /// <returns></returns>
        public Response Create(Objects.Discount discount)
        {
            //Props
            int statusCode = 201;
            Response response = new Response();

            //Random Tokens
            discount.Id = ServerUtil.GenerateToken(TokenLengths.TokensLength);
            try
            {
                Database.Connection.Open();

                string query = " INSERT INTO Discounts (DiscountId, Name, Description, StartDate, EndDate, Type, Value ) " +
                               " VALUES (@DiscountId, @Name, @Description, @StartDate, @EndDate, @Type, @Value) ";
                MySqlCommand Command = new MySqlCommand(query, Database.Connection);

                Command.Parameters.AddWithValue("DiscountId", discount.Id);
                Command.Parameters.AddWithValue("Name", discount.Name);
                Command.Parameters.AddWithValue("Description", discount.Description);
                Command.Parameters.AddWithValue("StartDate", discount.StartDate);
                Command.Parameters.AddWithValue("EndDate", discount.EndDate);
                Command.Parameters.AddWithValue("Type", discount.Type);
                Command.Parameters.AddWithValue("Value", discount.Value);
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
                Logger.QueryError(e, "Discount", "Create");

            }
            //Close Connection if Open
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            //Response

            response.StatusCode = statusCode;
            response.Data = discount;

            return response;
        }
                              
        /// <summary>
        /// Get 
        /// </summary>
        /// <returns></returns>
        public Response Get(Objects.Discount discount)
        {
            //Props
            int statusCode = 200;
            Response response = new Response();
            try
            {
                Database.Connection.Open();

                string Query = "SELECT * FROM Discounts WHERE DiscountId=@DiscountId";

                //Execute Query 
                MySqlCommand Command = new MySqlCommand(Query, Database.Connection);
                Command.Parameters.AddWithValue("DiscountId", discount.Id);
                MySqlDataReader DataReader = Command.ExecuteReader();

                //Read Data
                while (DataReader.Read())
                {
                    discount.Id = DataReader["DiscountId"].ToString();
                    discount.Name = DataReader["Name"].ToString();
                    discount.Type = DataReader["Type"].ToString();
                    discount.Value = decimal.Parse(DataReader["Value"].ToString());

                    discount.StartDate = Convert.ToDateTime(DataReader["StartDate"].ToString());
                    discount.EndDate = Convert.ToDateTime(DataReader["EndDate"].ToString());

                    discount.UpdatedAt = Convert.ToDateTime(DataReader["UpdatedAt"].ToString());
                    discount.CreatedAt = Convert.ToDateTime(DataReader["CreatedAt"].ToString());
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
                response.Data = discount;
            }
            catch (MySqlException e)
            {
                Logger.QueryError(e, "Discount", "Get");
                // Internal Error :
                response.StatusCode = 500;
            }
            //Close Connection if Open
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            return response;
        }

        /// <summary>
        /// Get Discounts
        /// </summary>
        /// <returns></returns>
        public Response GetDiscounts()
        {
            //Props
            int statusCode = 200;
            Response response = new Response();
            List<object> discounts = new List<object>();
            try
            {
                Database.Connection.Open();
                //search query or teyxt
                string query = " SELECT * FROM Discounts ORDER BY CreatedAt DESC ";

                //Execute Query 
                MySqlCommand Command = new MySqlCommand(query, Database.Connection);
                MySqlDataReader DataReader = Command.ExecuteReader();

                //Read Data
                while (DataReader.Read())
                {
                    Objects.Discount discount = new Objects.Discount
                    {
                        Id = DataReader["DiscountId"].ToString(),
                        Name = DataReader["Name"].ToString(),
                        Description = DataReader["Description"].ToString(),
                        Type = DataReader["Type"].ToString(),
                        Value = decimal.Parse(DataReader["Value"].ToString()),

                        StartDate = Convert.ToDateTime(DataReader["StartDate"].ToString()),
                        EndDate = Convert.ToDateTime(DataReader["EndDate"].ToString()),

                        UpdatedAt = Convert.ToDateTime(DataReader["UpdatedAt"].ToString()),
                        CreatedAt = Convert.ToDateTime(DataReader["CreatedAt"].ToString()),
                    };

                    discounts.Add(discount);
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
                response.DataArray = discounts;
            }
            catch (MySqlException e)
            {
                Logger.QueryError(e, "Discount", "Getting Discounts");
                // Internal Error :
                response.StatusCode = 500;
            }
            //Close Connection if Open
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            return response;
        }

        public string GetIdByName(string discountName)
        {
            string discountId = null;
            try
            {
                Database.Connection.Open();

                string query = " SELECT DiscountId FROM Discounts WHERE Name=@Name LIMIT 1";

                //Execute Query 
                MySqlCommand Command = new MySqlCommand(query, Database.Connection);
                Command.Parameters.AddWithValue("Name", discountName);
                MySqlDataReader DataReader = Command.ExecuteReader();

                //Read Data
                while (DataReader.Read())
                    discountId = DataReader["DiscountId"].ToString();

                Database.Connection.Close();
            }
            catch (MySqlException e)
            {
                Logger.QueryError(e, "Discount", "GetDiscountId");
            }
            return discountId;
        }

        /// <summary>
        ///  Update 
        public Response Update(Objects.Discount discount)
        {
            //Props
            int statusCode = 200;
            Response response = new Response();
            try
            {
                Database.Connection.Open();

                string query = " UPDATE Discounts SET Name=@Name, Description=@Description, StartDate=@StartDate, EndDate=@EndDate, Type=@Type, Value=@Value" +
                               " WHERE DiscountId=@DiscountId ";
                MySqlCommand Command = new MySqlCommand(query, Database.Connection);

                Command.Parameters.AddWithValue("DiscountId", discount.Id);
                Command.Parameters.AddWithValue("Name", discount.Name);
                Command.Parameters.AddWithValue("Description", discount.Description);
                Command.Parameters.AddWithValue("StartDate", discount.StartDate);
                Command.Parameters.AddWithValue("EndDate", discount.EndDate);
                Command.Parameters.AddWithValue("Type", discount.Type);
                Command.Parameters.AddWithValue("Value", discount.Value);

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

                Logger.QueryError(e, "Discount", "Update");
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
        public Response Delete(Objects.Discount discount)
        {
            //Props
            int statusCode = 204;
            Response response = new Response();
            try
            {
                Database.Connection.Open();

                string Query = "DELETE FROM Discounts WHERE DiscountId=@DiscountId ";
                //Execute Query With Connection  => DataReader
                MySqlCommand Command = new MySqlCommand(Query, Database.Connection);
                Command.Parameters.AddWithValue("DiscountId", discount.Id);

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
                Logger.QueryError(e, "Discount", "Delete ");
                // Internal Error :
                response.StatusCode = 500;
            }
            //Close Connection if Open
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            return response;
        }
                
        /// <summary>
        /// Add a Product to a Discount
        /// </summary>
        /// <returns></returns>
        public Response AddProduct(Objects.DiscountProduct product)
        {
            int statusCode = 201;
            Response response = new Response();
            try
            {
                Database.Connection.Open();

                string query = " INSERT INTO ProductDiscounts (DiscountId, ProductId) VALUES (@DiscountId, @ProductId) ";
                MySqlCommand Command = new MySqlCommand(query, Database.Connection);
                Command.Parameters.AddWithValue("DiscountId", product.DiscountId);
                Command.Parameters.AddWithValue("ProductId", product.ProductId);
                Command.ExecuteNonQuery();

                Database.Connection.Close();

                // Created
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
                Logger.QueryError(e, "Discount", "AddProduct");

            }
            //Close Connection if Open
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            //Response

            response.StatusCode = statusCode;
            response.Data = product;

            return response;
        }
        
        /// <summary>
        /// Get Products of Discount
        /// </summary>
        /// <returns></returns>
        public Response GetDiscountProducts(Objects.Discount discount)
        {
            int statusCode = 200;
            Response response = new Response();
            List<object> products = new List<object>();
            try
            {
                Database.Connection.Open();
                string query = " SELECT * FROM ProductDiscounts WHERE DiscountId=@DiscountId ORDER BY CreatedAt DESC ";
                //Execute Query 
                MySqlCommand Command = new MySqlCommand(query, Database.Connection);
                Command.Parameters.AddWithValue("DiscountId", discount.Id);
                MySqlDataReader DataReader = Command.ExecuteReader();

                //Read Data
                while (DataReader.Read())
                {
                    Objects.DiscountProduct product = new Objects.DiscountProduct
                    {
                        DiscountId = DataReader["DiscountId"].ToString(),
                        ProductId = DataReader["ProductId"].ToString(),
                        CreatedAt = Convert.ToDateTime(DataReader["CreatedAt"].ToString()),
                    };
                    products.Add(product);
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
                response.DataArray = products;
            }
            catch (MySqlException e)
            {
                Logger.QueryError(e, "Discount", "Getting Discount Products");
                // Internal Error :
                response.StatusCode = 500;
            }
            //Close Connection if Open
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            return response;
        }
        
        /// <summary>
        /// Remove a Product to a Discount
        /// </summary>
        /// <returns></returns>
        public Response RemoveProduct(Objects.DiscountProduct product)
        {
            int statusCode = 204;
            Response response = new Response();
            try
            {
                Database.Connection.Open();

                string Query = "DELETE FROM ProductDiscounts WHERE ProductId=@ProductId ";
                MySqlCommand Command = new MySqlCommand(Query, Database.Connection);
                Command.Parameters.AddWithValue("ProductId", product.ProductId);
                Command.ExecuteNonQuery();

                Database.Connection.Close();

                // OK : Successfully Deleted -> Returning No Content    
                statusCode = 204;
                response.StatusCode = statusCode;
            }
            catch (MySqlException e)
            {
                Logger.QueryError(e, "Discount", "RemoveProduct");
                // Internal Error :
                response.StatusCode = 500;
            }
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            return response;
        }

    }
}
