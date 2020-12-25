using System;
using System.Data;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

// Vendstor
using Vendstor.Backend.Data;
using Vendstor.Backend.Utils;
using Vendstor.Backend.Constants;

/** 
 * Copyright : © RigleSoft™,  Rigle™ - A Company of Franz Nkemaka™ -  All Rights Reserved 
 * Read README for more information. */

namespace Vendstor.Backend.Database.Queries
{
    /// <summary>
    /// Manage Customer
    /// </summary>
    public class Customer : Query
    {
        /// <summary>
        /// Checks if Id is valid
        /// </summary>       
        /// <returns></returns>
        public bool IsValid(Objects.Customer customer)
        {
            bool isValid;
            try
            {
                //Open Connection
                Database.Connection.Open();

                if (customer == null)
                    return false;

                string query = "SELECT CustomerId FROM Customers WHERE CustomerId=@CustomerId";
                MySqlCommand Command = new MySqlCommand(query, Database.Connection);
                Command.Parameters.AddWithValue("CustomerId", customer.Id);
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
                Logger.QueryError(e, "Customer", "Verifying Id");
                isValid = false;
            }

            //Close Connection if Open
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            return isValid;
        }

        /// <summary>
        /// Create a new Customer
        /// </summary>
        /// <returns></returns>
        public Response Create(Objects.Customer customer)
        {
            //Props
            int statusCode = 201;
            Response response = new Response();

            //Random Tokens
            customer.Id = ServerUtil.GenerateToken(TokenLengths.TokensLength);
            try
            {
                //Open MySqlConnection
                Database.Connection.Open();

                //Query
                string query = " INSERT INTO Customers (CustomerId, Code, FirstName, LastName, Email, PhoneNumber, Website, Address, " +
                               " PostCode, City, Country, IsFavorite, IsVerified, DateOfBirth, Sex) " +
                               " VALUES (@CustomerId, @Code, @FirstName, @LastName, @Email, @PhoneNumber, @Website, @Address, " +
                               " @PostCode, @City, @Country, @IsFavorite, @IsVerified, @DateOfBirth, @Sex) ";

                //Execute Query With MySqlConnection
                MySqlCommand Command = new MySqlCommand(query, Database.Connection);

                Command.Parameters.AddWithValue("CustomerId", customer.Id);
                Command.Parameters.AddWithValue("Code", customer.Code);
                Command.Parameters.AddWithValue("FirstName", customer.FirstName);
                Command.Parameters.AddWithValue("LastName", customer.LastName);
                Command.Parameters.AddWithValue("Email", customer.Email);
                Command.Parameters.AddWithValue("Sex", customer.Sex);
                Command.Parameters.AddWithValue("PhoneNumber", customer.PhoneNumber);
                Command.Parameters.AddWithValue("Website", customer.Website);
                Command.Parameters.AddWithValue("Address", customer.Address);
                Command.Parameters.AddWithValue("PostCode", customer.PostCode);
                Command.Parameters.AddWithValue("City", customer.City);
                Command.Parameters.AddWithValue("Country", customer.Country);
                Command.Parameters.AddWithValue("IsFavorite", Func.ToString(customer.IsFavorite));
                Command.Parameters.AddWithValue("IsVerified", Func.ToString(customer.IsVerified));
                Command.Parameters.AddWithValue("DateOfBirth", customer.DateOfBirth);

                Command.ExecuteNonQuery();

                //Close Connection
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
                Logger.QueryError(e, "Customer", "Create");

            }
            //Close Connection if Open
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            //Response

            response.StatusCode = statusCode;
            response.Data = customer;

            return response;
        }

        /// <summary>
        /// Get 
        /// </summary>
        /// <returns></returns>
        public Response Get(Objects.Customer customer)
        {
            //Props
            int statusCode = 200;
            Response response = new Response();
            try
            {
                //Open MySqlConnection
                Database.Connection.Open();

                //Query
                string Query = "SELECT * FROM Customers WHERE CustomerId=@CustomerId";

                //Execute Query 
                MySqlCommand Command = new MySqlCommand(Query, Database.Connection);
                Command.Parameters.AddWithValue("CustomerId", customer.Id);
                MySqlDataReader DataReader = Command.ExecuteReader();

                //Read Data
                while (DataReader.Read())
                {
                    customer.Id = DataReader["CustomerId"].ToString();
                    customer.Code = DataReader["Code"].ToString();
                    customer.FirstName = DataReader["FirstName"].ToString();
                    customer.LastName = DataReader["LastName"].ToString();
                    customer.Email = DataReader["Email"].ToString();
                    customer.PhoneNumber = DataReader["PhoneNumber"].ToString();
                    customer.Website = DataReader["Website"].ToString();
                    customer.Address = DataReader["Address"].ToString();
                    customer.PostCode = DataReader["PostCode"].ToString();
                    customer.City = DataReader["City"].ToString();
                    customer.Country = DataReader["Country"].ToString();
                    customer.Sex = DataReader["Sex"].ToString();

                    customer.StoreCredit = Func.ToDecimal(DataReader["StoreCredit"].ToString());

                    customer.IsFavorite = Func.ToBoolean(DataReader["IsFavorite"].ToString());
                    customer.IsVerified = Func.ToBoolean(DataReader["IsVerified"].ToString());


                    customer.DateOfBirth = Convert.ToDateTime(DataReader["DateOfBirth"].ToString());
                    customer.UpdatedAt = Convert.ToDateTime(DataReader["UpdatedAt"].ToString());
                    customer.RegisteredAt = Convert.ToDateTime(DataReader["RegisteredAt"].ToString());
                }
                if (!DataReader.HasRows)
                    // Bad Request 
                    statusCode = 400;
                else
                    // OK 
                    statusCode = 200;

                //Close Connection
                Database.Connection.Close();

                //Response 
                response.StatusCode = statusCode;
                response.Data = customer;
            }
            catch (MySqlException e)
            {
                Logger.QueryError(e, "Customer", "Get");
                // Internal Error :
                response.StatusCode = 500;
            }
            //Close Connection if Open
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            return response;
        }

        private string GetSearchQuery(Objects.CustomerSearchQuery searchQuery, bool hasLimit = false)
        {
            var order = " ORDER BY Customers.RegisteredAt DESC ";
            var append = (hasLimit) ? order + "  LIMIT @Limit" : order;
            var q = "  SELECT DISTINCT Customers.*, CustomerGroups.Name AS GroupName " +
                    "  FROM Customers " +
                    "  LEFT OUTER JOIN CustomerGroups " +
                    "  ON CustomerGroups.GroupId = Customers.GroupId ";

            switch (searchQuery.Type)
            {
                case Enums.SearchQueryType.None:
                    return q;

                case Enums.SearchQueryType.Id:
                    return q + " WHERE Customers.GroupId=@GroupId " + append;

                case Enums.SearchQueryType.Query:
                    return q + " WHERE (Customers.FirstName LIKE @SearchQuery OR Customers.Code LIKE @SearchQuery OR Customers.Email " +
                        " LIKE @SearchQuery OR Customers.LastName LIKE @SearchQuery) " + append;
                default:
                    return q;
            }
        }

        /// <summary>
        /// Get whole registered customers
        /// </summary>
        public Response GetCustomers(Objects.CustomerSearchQuery searchQuery, int limit = 0)
        {
            //Props
            int statusCode = 200;
            Response response = new Response();
            List<object> users = new List<object>();
            try
            {
                Database.Connection.Open();

                var q = $"%{searchQuery.Query}%";
                var query = GetSearchQuery(searchQuery, limit != 0);

                MySqlCommand Command = new MySqlCommand(query, Database.Connection);
                Command.Parameters.AddWithValue("SearchQuery", q);
                Command.Parameters.AddWithValue("GroupId", searchQuery.GroupId);
                //Command.Parameters.AddWithValue("Status", searchQuery.Status);
                Command.Parameters.AddWithValue("Limit", limit);

                MySqlDataReader DataReader = Command.ExecuteReader();
                //Read Data
                while (DataReader.Read())
                {
                    Objects.Customer customer = new Objects.Customer
                    {
                        Id = DataReader["CustomerId"].ToString(),
                        Code = DataReader["Code"].ToString(),
                        FirstName = DataReader["FirstName"].ToString(),
                        LastName = DataReader["LastName"].ToString(),
                        Email = DataReader["Email"].ToString(),
                        PhoneNumber = DataReader["PhoneNumber"].ToString(),
                        Website = DataReader["Website"].ToString(),
                        Address = DataReader["Address"].ToString(),
                        PostCode = DataReader["PostCode"].ToString(),
                        City = DataReader["City"].ToString(),
                        Country = DataReader["Country"].ToString(),
                        Sex = DataReader["Sex"].ToString(),

                        StoreCredit = Func.ToDecimal(DataReader["StoreCredit"].ToString()),

                        IsFavorite = Func.ToBoolean(DataReader["IsFavorite"].ToString()),
                        IsVerified = Func.ToBoolean(DataReader["IsVerified"].ToString()),

                        DateOfBirth = Convert.ToDateTime(DataReader["DateOfBirth"].ToString()),
                        UpdatedAt = Convert.ToDateTime(DataReader["UpdatedAt"].ToString()),
                        RegisteredAt = Convert.ToDateTime(DataReader["RegisteredAt"].ToString()),
                        Group = new Objects.CustomerGroup
                        {
                            Id = DataReader["GroupId"].ToString(),
                            Name = DataReader["GroupName"].ToString()
                        }
                    };
                    users.Add(customer);
                }
                if (!DataReader.HasRows)
                    // Empty
                    statusCode = 204;
                else
                    // OK 
                    statusCode = 200;

                //Close Connection
                Database.Connection.Close();

                //Response 
                response.StatusCode = statusCode;
                response.DataArray = users;
            }
            catch (MySqlException e)
            {
                Logger.QueryError(e, "Customer", "Getting Customers");
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
        public Response Update(Objects.Customer customer)
        {
            //Props
            int statusCode = 204;
            Response response = new Response();
            var isFavorite = customer.IsFavorite;
            var isVerified = customer.IsVerified;
            try
            {
                //Open Connection
                Database.Connection.Open();

                //Query
                string query = " UPDATE Customers  SET GroupId=@GroupId, FirstName=@FirstName, LastName=@LastName, Email=@Email, Sex=@Sex, PhoneNumber=@PhoneNumber, Website=@Website, Address=@Address, " +
                               " PostCode=@PostCode, City=@City, Country=@Country, IsFavorite=@IsFavorite, IsVerified=@IsVerified, DateOfBirth=@DateOfBirth  " +
                               " WHERE CustomerId=@CustomerId ";

                //Execute Query With MySqlConnection
                MySqlCommand Command = new MySqlCommand(query, Database.Connection);

                Command.Parameters.AddWithValue("CustomerId", customer.Id);
                Command.Parameters.AddWithValue("FirstName", customer.FirstName);
                Command.Parameters.AddWithValue("LastName", customer.LastName);
                Command.Parameters.AddWithValue("Email", customer.Email);
                Command.Parameters.AddWithValue("PhoneNumber", customer.PhoneNumber);
                Command.Parameters.AddWithValue("Website", customer.Website);
                Command.Parameters.AddWithValue("Sex", customer.Sex);
                Command.Parameters.AddWithValue("Address", customer.Address);
                Command.Parameters.AddWithValue("PostCode", customer.PostCode);
                Command.Parameters.AddWithValue("City", customer.City);
                Command.Parameters.AddWithValue("Country", customer.Country);
                Command.Parameters.AddWithValue("IsFavorite", Func.ToString(customer.IsFavorite));
                Command.Parameters.AddWithValue("IsVerified", Func.ToString(customer.IsVerified));
                Command.Parameters.AddWithValue("DateOfBirth", customer.DateOfBirth);

                if (customer.Group is object)
                    Command.Parameters.AddWithValue("GroupId", customer.Group.Id);

                Command.ExecuteNonQuery();

                //Close Connection
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

                Logger.QueryError(e, "Customer", "Update");
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
        public Response Delete(Objects.Customer customer)
        {
            //Props
            int statusCode = 204;
            Response response = new Response();
            try
            {
                Database.Connection.Open();

                string Query = "DELETE FROM Customers WHERE CustomerId=@CustomerId ";

                //Execute Query With Connection  => DataReader
                MySqlCommand Command = new MySqlCommand(Query, Database.Connection);
                Command.Parameters.AddWithValue("CustomerId", customer.Id);

                Command.ExecuteNonQuery();

                Database.Connection.Close();

                //[HTTP Status Code] OK : Successfully Deleted : Returning No Content    
                statusCode = 204;
                response.StatusCode = statusCode;
            }
            catch (MySqlException e)
            {
                Logger.QueryError(e, "Customer", "Delete");
                // Internal Error :
                response.StatusCode = 500;
            }
            //Close Connection if Open
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            return response;
        }

        /// <summary>
        /// Debit Customer StoreCredit (Substract)
        /// </summary>
        /// <returns></returns>
        public Response Debit(Objects.Customer customer, decimal amount)
        {
            int statusCode = 204;
            Response response = new Response();
            try
            {
                Database.Connection.Open();

                var query = "UPDATE Customers SET StoreCredit=ROUND(StoreCredit - @Amount, 2) WHERE CustomerId=@CustomerId";

                MySqlCommand Command = new MySqlCommand(query, Database.Connection);
                Command.Parameters.AddWithValue("CustomerId", customer.Id);
                Command.Parameters.AddWithValue("Amount", amount);
                Command.ExecuteNonQuery();

                Database.Connection.Close();

                // OK 
                statusCode = 204;

                //Response 
                customer.StoreCredit -= amount;
                response.StatusCode = statusCode;
                response.Data = customer;
            }
            catch (MySqlException e)
            {
                Logger.QueryError(e, "Customer", "Debit");
                // Internal Error :
                response.StatusCode = 500;
            }
            //Close Connection if Open
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            return response;
        }

        /// <summary>
        /// Redeem Customer StoreCredit (Add)
        /// </summary>
        /// <returns></returns>
        public Response Redeem(Objects.Customer customer, decimal amount)
        {
            int statusCode = 204;
            Response response = new Response();
            try
            {
                Database.Connection.Open();

                var query = "UPDATE Customers SET StoreCredit=ROUND(StoreCredit + @Amount, 2) WHERE CustomerId=@CustomerId";

                MySqlCommand Command = new MySqlCommand(query, Database.Connection);
                Command.Parameters.AddWithValue("CustomerId", customer.Id);
                Command.Parameters.AddWithValue("Amount", amount);
                Command.ExecuteNonQuery();

                Database.Connection.Close();

                // OK 
                statusCode = 204;
                //Response 
                customer.StoreCredit += amount;
                response.StatusCode = statusCode;
                response.Data = customer;
            }
            catch (MySqlException e)
            {
                Logger.QueryError(e, "Customer", "Redeem");
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
