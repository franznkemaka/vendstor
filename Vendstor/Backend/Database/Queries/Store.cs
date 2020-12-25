using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

// Vendstor
using Vendstor.Backend.Utils;
using Vendstor.Backend.Constants;
using Vendstor.Backend.Libraries;


/** 
 * Copyright : © RigleSoft™,  Rigle™ - A Company of Franz Nkemaka™ -  All Rights Reserved 
 * Read README for more information. */


namespace Vendstor.Backend.Database.Queries
{
    /// <summary>
    /// Manages a Vendstor Store : Register, Login, Update, Delete, Get
    /// </summary>
    public class Store : Query
    {
        private readonly PaymentType paymentType = new PaymentType();

        /// <summary>
        /// Check store Id, if ok returns true
        /// </summary>       
        /// <returns></returns>
        public bool IsIdValid(string storeId = null)
        {
            storeId = storeId ?? Properties.Settings.Default.StoreId;

            bool isValid;
            try
            {
                //Open Connection
                Database.Connection.Open();

                string query = "SELECT StoreId FROM Stores WHERE StoreId=@StoreId";
                MySqlCommand Command = new MySqlCommand(query, Database.Connection);
                Command.Parameters.AddWithValue("StoreId", storeId);
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
                Logger.QueryError(e, "Store", "Verifying Id");
                isValid = false;
            }

            //Close Connection if Open
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            return isValid;
        }

        /// <summary>
        /// Authentificate Store 
        /// </summary>
        /// <param name="email"> Store Owner Email</param>
        /// <param name="password"> Store Owner Password </param>          
        /// <returns></returns>
        public Response Login(Objects.Store store)
        {
            int statusCode = 201;
            //Props
            Response response = new Response();
            try
            {
                //Open Connection
                Database.Connection.Open();

                //Query
                string loginQuery = "SELECT StoreId FROM Stores WHERE Email=@Email AND Password=@Password";

                //Execute Query With MySqlConnection  => DataReader
                MySqlCommand Command = new MySqlCommand(loginQuery, Database.Connection);

                //Parameters For Security Purpose
                Command.Parameters.AddWithValue("Email", store.Email);
                Command.Parameters.AddWithValue("Password", store.Password);

                MySqlDataReader DataReader = Command.ExecuteReader();
                //Read Data
                while (DataReader.Read())
                    store.Id = DataReader["StoreId"].ToString();

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
                response.Data = store;
            }
            catch (MySqlException e)
            {
                Logger.QueryError(e, "Store", "Login");
                // Internal Error :
                response.StatusCode = 500;
            }
            //Close Connection if Open
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();
            return response;
        }

        /// <summary>
        /// Create a new Store
        /// </summary>
        /// <param name="storeName"> Store Name</param>
        /// <param name="email"> Store Owner Email</param>
        /// <param name="password"> Store Owner Password</param>
        /// <returns></returns>
        public Response Register(Objects.Store store)
        {
            //Props
            int statusCode = 201;
            Response response = new Response();
            //Random Tokens
            string storeId = ServerUtil.GenerateToken(TokenLengths.StoreIdLength);
            string verificationToken = ServerUtil.GenerateToken(TokenLengths.VerificationTokenLength);
            try
            {
                //Open MySqlConnection
                Database.Connection.Open();

                //Query
                string query = "INSERT INTO Stores (StoreId, Name, Email, Password, FirstName, LastName, PhoneNumber, Type, Locale, " +
                                    " Address, PostCode, City, Country, VerificationToken) " +
                               "VALUES (@StoreId, @Name, @Email, @Password, @FirstName, @LastName, @PhoneNumber, @Type, @Locale, " +
                                    " @Address, @PostCode, @City, @Country, @VerificationToken)";

                //Execute Query With MySqlConnection
                MySqlCommand Command = new MySqlCommand(query, Database.Connection);

                //Parameters For Security Purpose                  
                Command.Parameters.AddWithValue("StoreId", storeId);
                Command.Parameters.AddWithValue("Name", store.Name);
                Command.Parameters.AddWithValue("Email", store.Email);
                Command.Parameters.AddWithValue("Password", store.Password);
                Command.Parameters.AddWithValue("FirstName", store.FirstName);
                Command.Parameters.AddWithValue("LastName", store.LastName);
                Command.Parameters.AddWithValue("PhoneNumber", store.PhoneNumber);
                Command.Parameters.AddWithValue("Type", store.Type);
                Command.Parameters.AddWithValue("Locale", store.Locale);
                Command.Parameters.AddWithValue("Address", store.Address);
                Command.Parameters.AddWithValue("PostCode", store.PostCode);
                Command.Parameters.AddWithValue("City", store.City);
                Command.Parameters.AddWithValue("Country", store.Country);
                Command.Parameters.AddWithValue("VerificationToken", verificationToken);

                Command.ExecuteNonQuery();

                //Close Connection
                Database.Connection.Close();

                paymentType.Create(store);

                // Status Code
                statusCode = 201;

                store.Id = storeId;
                store.VerificationToken = verificationToken;

                //Response                 
                response.StatusCode = statusCode;
                response.Data = store;
            }
            catch (MySqlException e)
            {
                if (e.Message.Contains("Duplicate entry"))
                    //Duplicate Key or Conflict
                    statusCode = 409;
                else
                    // Internal Server Error
                    statusCode = 500;
                Logger.QueryError(e, "Store",  "Register");

                // Status Code
                response.StatusCode = statusCode;
            }
            //Close Connection if Open
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            return response;
        }

        /// <summary>
        /// Get Store 
        /// </summary>
        /// <param name="storeId"></param>
        /// <returns></returns>
        public Response Get(Objects.Store store)
        {
            //Props
            int statusCode = 200;
            store.Id = store.Id ?? Properties.Settings.Default.StoreId;
            Response response = new Response();
            try
            {
                //Open MySqlConnection
                Database.Connection.Open();

                //Query
                string Query = "SELECT * FROM Stores WHERE StoreId=@StoreId";

                //Execute Query With MySqlConnection  => DataReader
                MySqlCommand Command = new MySqlCommand(Query, Database.Connection);

                //Parameters For Security Purpose
                Command.Parameters.AddWithValue("StoreId", store.Id);
                MySqlDataReader DataReader = Command.ExecuteReader();

                //Read Data
                while (DataReader.Read())
                {
                    store.Id = DataReader["StoreId"].ToString();
                    store.Name = DataReader["Name"].ToString();
                    store.Email = DataReader["Email"].ToString();
                    store.Password = DataReader["Password"].ToString();
                    store.FirstName = DataReader["FirstName"].ToString();
                    store.LastName = DataReader["LastName"].ToString();
                    store.PhoneNumber = DataReader["PhoneNumber"].ToString();
                    store.Type = DataReader["Type"].ToString();
                    store.Locale = DataReader["Locale"].ToString();
                    store.Currency = DataReader["Currency"].ToString();
                    store.Address = DataReader["Address"].ToString();
                    store.PostCode = DataReader["PostCode"].ToString();
                    store.City = DataReader["City"].ToString();
                    store.Country = DataReader["Country"].ToString();
                    store.Status = DataReader["Status"].ToString();

                    store.IsEmailVerified = Func.ToBoolean(DataReader["IsEmailVerified"].ToString());
                    store.IsVerified = Func.ToBoolean(DataReader["IsVerified"].ToString());

                    store.VerificationToken = DataReader["VerificationToken"].ToString();
                    store.UpdatedAt = Convert.ToDateTime(DataReader["UpdatedAt"].ToString());
                    store.RegisteredAt = Convert.ToDateTime(DataReader["RegisteredAt"].ToString());
                }
                if (!DataReader.HasRows)
                    // Bad Request 
                    statusCode = 400;
                else
                    // OK 
                    statusCode = 200;

                //Close Connection
                Database.Connection.Close();

                store.PaymentTypes = paymentType.Get(store);

                //Response 
                response.StatusCode = statusCode;
                response.Data = store;
            }
            catch (MySqlException e)
            {
                Logger.QueryError(e, "Store",  "Getting Store");
                // Internal Error :
                response.StatusCode = 500;
            }
            //Close Connection if Open
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            return response;
        }
        
        /// <summary>
        /// Get Store Insights
        /// </summary>
        /// <returns></returns>
        public Response GetInsights(Objects.Insights insights)
        {
            int statusCode = 200;
            Response response = new Response();
            try
            {
                Database.Connection.Open();

                var yearMonth = DateUtil.GetYearAndMonth(DateTime.Now);
                var weekNumOfYear = DateUtil.GetWeekNumber(DateTime.Now);

                var query = "SELECT  " +
                    "( SELECT COUNT(*) FROM Products )  As TotalProductsCount, " +
                    "( SELECT COUNT(*) FROM Customers ) As TotalCustomersCount , " +
                    "( SELECT COUNT(*) FROM Sales WHERE (EXTRACT(WEEK FROM SoldAt) = @WeekNumOfYear )) AS WeeklySalesCount,  " +
                    "( SELECT SUM(TotalPrice) FROM Sales WHERE (EXTRACT(YEAR_MONTH FROM SoldAt) = @YearMonth )) AS MonthlyRevenue,  " + 
                    "( SELECT SUM(TotalPrice) FROM Sales ) AS TotalRevenue ";

                MySqlCommand Command = new MySqlCommand(query, Database.Connection);
                Command.Parameters.AddWithValue("WeekNumOfYear", weekNumOfYear);
                Command.Parameters.AddWithValue("YearMonth", yearMonth);
                MySqlDataReader DataReader = Command.ExecuteReader();

                while (DataReader.Read())
                {
                    insights.TotalRevenue = Func.ToDecimal(DataReader["TotalRevenue"].ToString());
                    insights.MonthlyRevenue = Func.ToDecimal(DataReader["MonthlyRevenue"].ToString());
                    
                    insights.TotalProductsCount = Func.ToDouble(DataReader["TotalProductsCount"].ToString());
                    insights.TotalCustomersCount = Func.ToDouble(DataReader["TotalCustomersCount"].ToString());
                    insights.WeeklySalesCount = Func.ToDouble(DataReader["WeeklySalesCount"].ToString());
                    insights.UpdatedAt = DateTime.Now;
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
                response.Data = insights;
            }
            catch (MySqlException e)
            {
                Logger.QueryError(e, "Store", "Getting Insights");
                // Internal Error :
                response.StatusCode = 500;
            }
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            return response;
        }
        
        /// <summary>
        /// Get Top Sold Products
        /// </summary>
        /// <returns></returns>
        public Response GetTopSoldProducts(Objects.Insights insights, int limit = 0)
        {
            int statusCode = 200;
            Response response = new Response();
            List<object> products = new List<object>();
            try
            {
                Database.Connection.Open();

                var append = (limit != 0) ? " LIMIT @Limit" : " "; 
                var query = " SELECT DISTINCT " +
                            " SUM(SaleItems.Quantity) As TotalQuantity, Products.* " +
                            " FROM SaleItems INNER JOIN Products " +
                                    " ON Products.ProductId = SaleItems.ProductId " +
                             "GROUP BY ProductId " +
                             "ORDER BY TotalQuantity DESC" + append;
                
                MySqlCommand Command = new MySqlCommand(query, Database.Connection);
                Command.Parameters.AddWithValue("Limit", limit);
                MySqlDataReader DataReader = Command.ExecuteReader();

                while (DataReader.Read())
                {
                    Objects.Product product = new Objects.Product
                    {
                        Id = DataReader["ProductId"].ToString(),
                        Barcode = DataReader["Barcode"].ToString(),
                        Name = DataReader["Name"].ToString(),
                        Description = DataReader["Description"].ToString(),

                        Stock = decimal.Parse(DataReader["Stock"].ToString()),
                        IsBalanceRequired = Func.ToBoolean(DataReader["IsBalanceRequired"].ToString()),
                        SupplyPrice = decimal.Parse(DataReader["SupplyPrice"].ToString()),
                        RetailPrice = decimal.Parse(DataReader["RetailPrice"].ToString()),
                        Markup = decimal.Parse(DataReader["Markup"].ToString()),
                        ImageBlobId = DataReader["ImageBlobId"].ToString(),
                        Color = ColorUtil.HEXToColor(DataReader["Color"].ToString()),

                        UpdatedAt = Convert.ToDateTime(DataReader["UpdatedAt"].ToString()),
                        CreatedAt = Convert.ToDateTime(DataReader["CreatedAt"].ToString()),

                        Tax = new Objects.Tax { Id = DataReader["TaxId"].ToString() },
                        Brand = new Objects.ProductBrand { Id = DataReader["BrandId"].ToString() },
                        Supplier = new Objects.ProductSupplier { Id = DataReader["SupplierId"].ToString() },
                        Type = new Objects.ProductType { Id = DataReader["TypeId"].ToString() },

                        IsSearchItem = true,
                    };

                    products.Add(product);
                }
                if (!DataReader.HasRows)
                    // No Content
                    statusCode = 204;
                else
                    // OK 
                    statusCode = 200;

                Database.Connection.Close();

                //Response 
                insights.TopSoldProducts = products;
                response.StatusCode = statusCode;
                response.Data = insights;
            }
            catch (MySqlException e)
            {
                Logger.QueryError(e, "Store", "Getting Top Sold Products");
                // Internal Error :
                response.StatusCode = 500;
            }
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            return response;
        }
        
        /// <summary>
        /// Get Daily Revenue Data
        /// </summary>
        /// <returns></returns>
        public Response GetDailyRevenueData(Objects.Insights insights)
        {
            int statusCode = 200;
            Response response = new Response();
            List<object> chartData = new List<object>();
            try
            {
                Database.Connection.Open();

                var query = " SELECT SUM(TotalPrice) As Amount, SoldAt  " +
                            " FROM Sales " +
                            " WHERE SoldAt BETWEEN  NOW() + INTERVAL -7 DAY AND  NOW() " +
                            " GROUP BY DATE(SoldAt)";

                MySqlCommand Command = new MySqlCommand(query, Database.Connection);
                MySqlDataReader DataReader = Command.ExecuteReader();

                while (DataReader.Read())
                {
                    Objects.DailyRevenueChart data = new Objects.DailyRevenueChart
                    {
                        Amount = decimal.Parse(DataReader["Amount"].ToString()),
                        Date = Convert.ToDateTime(DataReader["SoldAt"].ToString()),
                    };

                    chartData.Add(data);
                }
                if (!DataReader.HasRows)
                    // No Content
                    statusCode = 204;
                else
                    // OK 
                    statusCode = 200;

                Database.Connection.Close();

                //Response 
                insights.ChartData = chartData;
                response.StatusCode = statusCode;
                response.Data = insights;
            }
            catch (MySqlException e)
            {
                Logger.QueryError(e, "Store", "Getting Daily Revenue Data");
                // Internal Error :
                response.StatusCode = 500;
            }
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            return response;
        }

        /// <summary>
        /// Get Daily Sales Data
        /// </summary>
        /// <returns></returns>
        public Response GetDailySalesData(Objects.Insights insights)
        {
            int statusCode = 200;
            Response response = new Response();
            List<object> chartData = new List<object>();
            try
            {
                Database.Connection.Open();

                var query = " SELECT COUNT(*) As SalesCount, SoldAt  " +
                            " FROM Sales " +
                            " WHERE SoldAt BETWEEN  NOW() + INTERVAL -7 DAY AND  NOW() " +
                            " GROUP BY DATE(SoldAt)";

                MySqlCommand Command = new MySqlCommand(query, Database.Connection);
                MySqlDataReader DataReader = Command.ExecuteReader();

                while (DataReader.Read())
                {
                    Objects.DailySalesChart data = new Objects.DailySalesChart
                    {
                        Count = decimal.Parse(DataReader["SalesCount"].ToString()),
                        Date = Convert.ToDateTime(DataReader["SoldAt"].ToString()),
                    };

                    chartData.Add(data);
                }
                if (!DataReader.HasRows)
                    // No Content
                    statusCode = 204;
                else
                    // OK 
                    statusCode = 200;

                Database.Connection.Close();

                //Response 
                insights.ChartData = chartData;
                response.StatusCode = statusCode;
                response.Data = insights;
            }
            catch (MySqlException e)
            {
                Logger.QueryError(e, "Store", "Getting Daily Sales Count Data");
                // Internal Error :
                response.StatusCode = 500;
            }
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            return response;
        }
        
        /// <summary>
        /// Get Weekly Customers Data
        /// </summary>
        /// <returns></returns>
        public Response GetWeeklyCustomersData(Objects.Insights insights)
        {
            int statusCode = 200;
            Response response = new Response();
            List<object> chartData = new List<object>();
            try
            {
                Database.Connection.Open();

                var query = " SELECT COUNT(*) As CustomersCount, RegisteredAt  " +
                            " FROM Customers " +
                            " WHERE RegisteredAt BETWEEN NOW() + INTERVAL - 7 DAY AND  NOW() " +
                            " GROUP BY DATE(RegisteredAt)";

                MySqlCommand Command = new MySqlCommand(query, Database.Connection);
                MySqlDataReader DataReader = Command.ExecuteReader();

                while (DataReader.Read())
                {
                    Objects.WeeklyCustomersChart data = new Objects.WeeklyCustomersChart
                    {
                        Count = decimal.Parse(DataReader["CustomersCount"].ToString()),
                        Date = Convert.ToDateTime(DataReader["RegisteredAt"].ToString()),
                    };

                    chartData.Add(data);
                }
                if (!DataReader.HasRows)
                    // No Content
                    statusCode = 204;
                else
                    // OK 
                    statusCode = 200;

                Database.Connection.Close();

                //Response 
                insights.ChartData = chartData;
                response.StatusCode = statusCode;
                response.Data = insights;
            }
            catch (MySqlException e)
            {
                Logger.QueryError(e, "Store", "Getting Weekly Customers Count Data");
                // Internal Error :
                response.StatusCode = 500;
            }
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            return response;
        }

        /// <summary>
        ///  Update Store
        /// </summary>
        /// <returns></returns>
        public Response Update(Objects.Store store)
        {
            //Props
            int statusCode = 204;
            Response response = new Response();
            var isEmailVerified = Func.ToString( store.IsEmailVerified);
            var isVerified = Func.ToString(store.IsVerified);
            try
            {
                //Open Connection
                Database.Connection.Open();

                //Query
                string query = " UPDATE Stores SET Name=@Name, Email=@Email, Password=@Password, FirstName=@FirstName, LastName=@LastName, " +
                                    " PhoneNumber=@PhoneNumber, Type=@Type, Locale=@Locale, Currency=@Currency, Address=@Address, PostCode=@PostCode, " +
                                    " City=@City, Country=@Country, Status=@Status, IsEmailVerified=@IsEmailVerified, IsVerified=@IsVerified, VerificationToken=@VerificationToken " +
                               " WHERE StoreId=@StoreId";

                //Execute Query With MySqlConnection  => DataReader
                MySqlCommand Command = new MySqlCommand(query, Database.Connection);

                //Parameters For Security Purpose         
                Command.Parameters.AddWithValue("StoreId", store.Id);
                Command.Parameters.AddWithValue("Name", store.Name);
                Command.Parameters.AddWithValue("Email", store.Email);
                Command.Parameters.AddWithValue("Password", store.Password);
                Command.Parameters.AddWithValue("FirstName", store.FirstName);
                Command.Parameters.AddWithValue("LastName", store.LastName);
                Command.Parameters.AddWithValue("PhoneNumber", store.PhoneNumber);
                Command.Parameters.AddWithValue("Type", store.Type);
                Command.Parameters.AddWithValue("Locale", store.Locale);
                Command.Parameters.AddWithValue("Currency", store.Currency);
                Command.Parameters.AddWithValue("Address", store.Address);
                Command.Parameters.AddWithValue("PostCode", store.PostCode);
                Command.Parameters.AddWithValue("City", store.City);
                Command.Parameters.AddWithValue("Country", store.Country);

                Command.Parameters.AddWithValue("Status", store.Status);
                Command.Parameters.AddWithValue("IsEmailVerified", isEmailVerified);
                Command.Parameters.AddWithValue("IsVerified", isVerified);

                Command.Parameters.AddWithValue("VerificationToken", store.VerificationToken);
                Command.ExecuteNonQuery();

                //Close Connection
                Database.Connection.Close();

                // Updated Successfully 
                statusCode = 204;

                //Response 
                response.StatusCode = statusCode;
                response.Data = store;
            }
            catch (MySqlException e)
            {
                if (e.Message.Contains("Duplicate entry"))
                    //Duplicate Key or Conflict
                    statusCode = 409;
                else
                    // Internal Server Error
                    statusCode = 500;

                Logger.QueryError(e, "Store", "Updating Store");
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
