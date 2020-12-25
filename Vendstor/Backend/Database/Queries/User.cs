using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;

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
    /// Manage Store Users : Register, Login, Update, Delete, GetInfo
    /// </summary>
    public class User : Query
    {
        /// <summary>
        /// Check store Id, if ok returns true
        /// </summary>       
        /// <returns></returns>
        public bool IsIdValid(string userId = null)
        {
            userId = userId ?? Properties.Settings.Default.UserId;
            bool isValid;
            try
            {
                //Open Connection
                Database.Connection.Open();

                string query = "SELECT UserId FROM Users WHERE UserId=@UserId";
                MySqlCommand Command = new MySqlCommand(query, Database.Connection);
                Command.Parameters.AddWithValue("UserId", userId);
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
                Logger.QueryError(e, "User", "Verifying Id");
                isValid = false;
            }

            //Close Connection if Open
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            return isValid;
        }

        /// <summary>
        ///  Authentificate User 
        /// </summary>
        /// <param name="email"> User Email</param>
        /// <param name="password"> User Password </param>          
        /// <returns></returns>
        public Response Login(Objects.User user)
        {
            //Props
            int statusCode = 200;
            Response response = new Response();
            try
            {
                /* Connection & Query */

                Database.Connection.Open();

                string loginQuery = "SELECT UserId FROM Users WHERE Email=@Email AND Password=@Password";

                //Execute Query With Connection  => DataReader
                MySqlCommand Command = new MySqlCommand(loginQuery, Database.Connection);
                Command.Parameters.AddWithValue("Email", user.Email);
                Command.Parameters.AddWithValue("Password", user.Password);

                MySqlDataReader DataReader = Command.ExecuteReader();

                while (DataReader.Read())
                    user.Id = DataReader["UserId"].ToString();

                if (!DataReader.HasRows)
                    // Bad Request 
                    statusCode = 400;
                else
                    // OK 
                    statusCode = 200;

                Database.Connection.Close();

                /* Response */
                response.StatusCode = statusCode;
                response.Data = user;
            }
            catch (MySqlException e)
            {
                /* Errors */
                Logger.QueryError(e, "User", "Login");
                response.StatusCode = 500;
            }

            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            return response;
        }

        /// <summary>
        ///  Authentificate User 
        /// </summary>
        /// <param name="pin"> User PIN</param>
        /// <returns></returns>
        public Response PinLogin(Objects.User user)
        {
            //Props
            int statusCode = 200;
            Response response = new Response();
            try
            {
                //Open Connection
                Database.Connection.Open();

                //Query
                string loginQuery = "SELECT UserId FROM Users WHERE PinCode=@PinCode";

                //Execute Query With Connection  => DataReader
                MySqlCommand Command = new MySqlCommand(loginQuery, Database.Connection);

                //Parameters For Security Purpose
                Command.Parameters.AddWithValue("PinCode", user.PinCode);

                MySqlDataReader DataReader = Command.ExecuteReader();
                //Read Data
                while (DataReader.Read())
                    user.Id = DataReader["UserId"].ToString();

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
                response.Data = user;
            }
            catch (MySqlException e)
            {
                Logger.QueryError(e, "User", "PIN Login");
                // Internal Error :
                response.StatusCode = 500;
            }
            //Close Connection if Open
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            return response;
        }

        /// <summary>
        ///  Authentificate User 
        /// </summary>
        /// <param name="email"> User Email</param>
        /// <param name="password"> User Password </param>          
        /// <returns></returns>
        public Response TokenLogin(Objects.User user)
        {
            //Props
            int statusCode = 200;
            Response response = new Response();
            try
            {
                Database.Connection.Open();

                string loginQuery = "SELECT UserId FROM Users WHERE Token=@Token";
                MySqlCommand Command = new MySqlCommand(loginQuery, Database.Connection);
                Command.Parameters.AddWithValue("Token", user.Token);

                MySqlDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                    user.Id = DataReader["UserId"].ToString();

                if (!DataReader.HasRows)
                    // Bad Request 
                    statusCode = 400;
                else
                    // OK 
                    statusCode = 200;
                Database.Connection.Close();
                //Response 
                response.StatusCode = statusCode;
                response.Data = user;
            }
            catch (MySqlException e)
            {
                Logger.QueryError(e, "User", "Token Login");
                // Internal Error :
                response.StatusCode = 500;
            }
            //Close Connection if Open
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            return response;
        }

        /// <summary>
        /// Create a new User
        /// </summary>
        /// <param name="username"> Username</param>
        /// <param name="email"> User Email</param>
        /// <param name="password"> User Password</param>
        /// <param name="pin"> User PIN </param>
        /// <returns></returns>
        public Response Register(Objects.User user, Objects.Store store)
        {
            //Props
            int statusCode = 201;
            Response response = new Response();

            //Random Tokens
            string userId = ServerUtil.GenerateToken(TokenLengths.UserIdLength);
            string userToken = ServerUtil.GenerateToken(TokenLengths.UserTokenLength);
            user.PinCode = user.PinCode ?? ServerUtil.GenerateRandomNum(minChar: 100000, maxChar: 999999).ToString();
            store.Id = store.Id ?? Properties.Settings.Default.StoreId;
            var _color = ColorUtil.ToHEXColor(user.Color);
            try
            {
                //Open MySqlConnection
                Database.Connection.Open();
                //Query
                string query = "INSERT INTO Users (UserId, Token, StoreId, Username, Password, FirstName, LastName, Email, " +
                                    " PinCode, Role, Locale, Color, ImageBlobId) " +
                               "VALUES (@UserId, @Token, @StoreId, @Username, @Password, @FirstName, @LastName, @Email, " +
                                    " @PinCode, @Role, @Locale, @Color, @ImageBlobId)";

                //Execute Query With MySqlConnection
                MySqlCommand Command = new MySqlCommand(query, Database.Connection);

                //Parameters For Security Purpose                  
                Command.Parameters.AddWithValue("UserId", userId);
                Command.Parameters.AddWithValue("Token", userToken);
                Command.Parameters.AddWithValue("StoreId", store.Id);
                Command.Parameters.AddWithValue("Username", user.Username);
                Command.Parameters.AddWithValue("Password", user.Password);
                Command.Parameters.AddWithValue("FirstName", user.FirstName);
                Command.Parameters.AddWithValue("LastName", user.LastName);
                Command.Parameters.AddWithValue("Email", user.Email);
                Command.Parameters.AddWithValue("PinCode", user.PinCode);
                Command.Parameters.AddWithValue("Role", user.Role);
                Command.Parameters.AddWithValue("Locale", user.Locale);
                Command.Parameters.AddWithValue("Color", _color);
                Command.Parameters.AddWithValue("ImageBlobId", user.ImageBlobId);

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
                Logger.QueryError(e, "User", "Register");

            }
            //Close Connection if Open
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            //Response

            response.StatusCode = statusCode;
            response.Data = user;

            return response;
        }



        /// <summary>
        /// Get Whole Registered Users if Admin
        /// </summary>
        public Response GetUsers(Objects.Store store)
        {
            //Props
            int statusCode = 200;
            Response response = new Response();
            List<object> users = new List<object>();
            store.Id = store.Id ?? Properties.Settings.Default.StoreId;

            try
            {
                Database.Connection.Open();

                string query = " SELECT DISTINCT Users.*, Blobs.Path As ProfileImageUrl " +
                               " FROM Users " +
                               " LEFT OUTER JOIN Blobs " +
                               " ON Blobs.BlobId = Users.ImageBlobId  " +
                               " ORDER BY RegisteredAt DESC ";

                //Execute Query With Connection  => DataReader
                MySqlCommand Command = new MySqlCommand(query, Database.Connection);
                Command.Parameters.AddWithValue("StoreId", store.Id);
                MySqlDataReader DataReader = Command.ExecuteReader();

                //Read Data
                while (DataReader.Read())
                {
                    Objects.User user = new Objects.User
                    {
                        Id = DataReader["UserId"].ToString(),
                        Token = DataReader["Token"].ToString(),
                        Username = DataReader["Username"].ToString(),
                        Password = DataReader["Password"].ToString(),
                        FirstName = DataReader["FirstName"].ToString(),
                        LastName = DataReader["LastName"].ToString(),
                        Email = DataReader["Email"].ToString(),
                        PinCode = DataReader["PinCode"].ToString(),
                        Role = DataReader["Role"].ToString(),
                        Locale = DataReader["Locale"].ToString(),
                        ImageBlobId = DataReader["ImageBlobId"].ToString(),
                        IsOnline = Func.ToBoolean(DataReader["IsOnline"].ToString()),
                        IsVerified = Func.ToBoolean(DataReader["IsVerified"].ToString()),
                        Color = ColorUtil.HEXToColor(DataReader["Color"].ToString()),
                        LastActive = Convert.ToDateTime(DataReader["LastActive"].ToString()),
                        RegisteredAt = Convert.ToDateTime(DataReader["RegisteredAt"].ToString()),
                    };

                    user.ProfileImage = GetProfileImage(user.ImageBlobId, user.FirstName, user.Color,
                        doRequest: false, imageUrl: DataReader["ProfileImageUrl"].ToString());

                    users.Add(user);
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
                response.DataArray = users;
            }
            catch (MySqlException e)
            {
                Logger.QueryError(e, "User", "Getting Users");
                // Internal Error :
                response.StatusCode = 500;
            }
            //Close Connection if Open
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            return response;
        }

        /// <summary>
        /// Get User 
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public Response Get(Objects.User user)
        {
            //Props
            int statusCode = 200;
            user.Id = user.Id ?? Properties.Settings.Default.UserId;
            Response response = new Response();
            try
            {
                //Open MySqlConnection
                Database.Connection.Open();

                //Query
                string Query = "SELECT * FROM Users WHERE UserId=@UserId";

                //Execute Query 
                MySqlCommand Command = new MySqlCommand(Query, Database.Connection);
                Command.Parameters.AddWithValue("UserId", user.Id);
                MySqlDataReader DataReader = Command.ExecuteReader();

                //Read Data
                while (DataReader.Read())
                {
                    user.Id = DataReader["UserId"].ToString();
                    user.Token = DataReader["Token"].ToString();
                    user.Username = DataReader["Username"].ToString();
                    user.Password = DataReader["Password"].ToString();
                    user.FirstName = DataReader["FirstName"].ToString();
                    user.LastName = DataReader["LastName"].ToString();
                    user.Email = DataReader["Email"].ToString();
                    user.PinCode = DataReader["PinCode"].ToString();
                    user.Role = DataReader["Role"].ToString();
                    user.Locale = DataReader["Locale"].ToString();
                    user.ImageBlobId = DataReader["ImageBlobId"].ToString();

                    user.IsOnline = Func.ToBoolean(DataReader["IsOnline"].ToString());
                    user.IsVerified = Func.ToBoolean(DataReader["IsVerified"].ToString());

                    user.Color = ColorUtil.HEXToColor(DataReader["Color"].ToString());

                    user.LastActive = Convert.ToDateTime(DataReader["LastActive"].ToString());
                    user.RegisteredAt = Convert.ToDateTime(DataReader["RegisteredAt"].ToString());
                }
                if (!DataReader.HasRows)
                    // Bad Request 
                    statusCode = 400;
                else
                    // OK 
                    statusCode = 200;

                //Close Connection
                Database.Connection.Close();

                //GetImage Color
                user.ProfileImage = GetProfileImage(user.ImageBlobId, user.FirstName, user.Color);

                //Response 
                response.StatusCode = statusCode;
                response.Data = user;
            }
            catch (MySqlException e)
            {
                Logger.QueryError(e, "User", "Getting User");
                // Internal Error :
                response.StatusCode = 500;
            }
            //Close Connection if Open
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            return response;
        }

        /// <summary>
        /// Get User Insights
        /// </summary>
        /// <returns></returns>
        public Response GetInsights(Objects.User user)
        {
            int statusCode = 200;
            //user.Id = user.Id ?? Properties.Settings.Default.UserId;
            Response response = new Response();
            try
            {
                Database.Connection.Open();

                var yearMonth = DateUtil.GetYearAndMonth(DateTime.Now);
                var weekNumOfYear = DateUtil.GetWeekNumber(DateTime.Now);
                var year = DateUtil.GetYear(DateTime.Now);

                var query = "SELECT  " +
                    "( SELECT SUM(TotalPrice) FROM Sales WHERE(UserId =@UserId AND SoldAt BETWEEN CURRENT_DATE() AND(NOW() + INTERVAL 1 DAY)) ) AS DailyRevenue, " +
                    "( SELECT SUM(TotalPrice) FROM Sales WHERE(UserId =@UserId AND EXTRACT(WEEK FROM SoldAt) = @WeekNumOfYear)) AS WeeklyRevenue, " +
                    "( SELECT SUM(TotalPrice) FROM Sales WHERE(UserId =@UserId AND  EXTRACT(YEAR_MONTH FROM SoldAt) = @YearMonth) ) AS MonthlyRevenue,  " +
                    "( SELECT SUM(TotalPrice) FROM Sales WHERE(UserId =@UserId AND YEAR(SoldAt) = @Year) ) AS YearlyRevenue, " +
                    "( SELECT SUM(TotalPrice) FROM Sales WHERE(UserId =@UserId) ) AS TotalRevenue, " +

                    "( SELECT COUNT(*) FROM Sales WHERE(UserId =@UserId AND SoldAt BETWEEN CURRENT_DATE() AND(NOW() + INTERVAL 1 DAY)) ) AS DailySalesCount, " +
                    "( SELECT COUNT(*) FROM Sales WHERE(UserId =@UserId AND EXTRACT(WEEK FROM SoldAt) = @WeekNumOfYear)) AS WeeklySalesCount, " +
                    "( SELECT COUNT(*) FROM Sales WHERE(UserId =@UserId AND  EXTRACT(YEAR_MONTH FROM SoldAt) = @YearMonth) ) AS MonthlySalesCount,  " +
                    "( SELECT COUNT(*) FROM Sales WHERE(UserId =@UserId AND YEAR(SoldAt) = @Year) ) AS YearlySalesCount, " +
                    "( SELECT COUNT(*) FROM Sales WHERE(UserId =@UserId) ) AS TotalSalesCount";

                MySqlCommand Command = new MySqlCommand(query, Database.Connection);
                Command.Parameters.AddWithValue("UserId", user.Id);
                Command.Parameters.AddWithValue("WeekNumOfYear", weekNumOfYear);
                Command.Parameters.AddWithValue("YearMonth", yearMonth);
                Command.Parameters.AddWithValue("Year", year);
                MySqlDataReader DataReader = Command.ExecuteReader();

                while (DataReader.Read())
                {
                    user.DailyRevenue = Func.ToDecimal(DataReader["DailyRevenue"].ToString());
                    user.WeeklyRevenue = Func.ToDecimal(DataReader["WeeklyRevenue"].ToString());
                    user.MonthlyRevenue = Func.ToDecimal(DataReader["MonthlyRevenue"].ToString());
                    user.YearlyRevenue = Func.ToDecimal(DataReader["YearlyRevenue"].ToString());
                    user.TotalRevenue = Func.ToDecimal(DataReader["TotalRevenue"].ToString());

                    user.DailySalesCount = Func.ToDouble(DataReader["DailySalesCount"].ToString());
                    user.WeeklySalesCount = Func.ToDouble(DataReader["WeeklySalesCount"].ToString());
                    user.MonthlySalesCount = Func.ToDouble(DataReader["MonthlySalesCount"].ToString());
                    user.YearlySalesCount = Func.ToDouble(DataReader["YearlySalesCount"].ToString());
                    user.TotalSalesCount = Func.ToDouble(DataReader["TotalSalesCount"].ToString());
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
                response.Data = user;
            }
            catch (MySqlException e)
            {
                Logger.QueryError(e, "User", "Getting User Insights");
                // Internal Error :
                response.StatusCode = 500;
            }
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            return response;
        }

        public static string GetIdByName(string username)
        {
            string userId = null;
            try
            {
                Database.Connection.Open();
                string query = " SELECT UserId FROM Users WHERE Username=@Username LIMIT 1";
                //Execute Query 
                MySqlCommand Command = new MySqlCommand(query, Database.Connection);
                Command.Parameters.AddWithValue("Username", username);
                MySqlDataReader DataReader = Command.ExecuteReader();
                //Read Data
                while (DataReader.Read())
                    userId = DataReader["UserId"].ToString();
                Database.Connection.Close();
            }
            catch (MySqlException e)
            {
                Logger.QueryError(e, "User", "GetIdByName");
            }
            return userId;
        }

        public static Image GetProfileImage(string imageBlobId, string displayName, Color color, bool doRequest = true, string imageUrl = null)
        {
            if (Validation.IsTokenValid(imageBlobId))
            {
                if (doRequest)
                {
                    Blob blob = new Blob();
                    var res = blob.Get(imageBlobId);
                    if (res.StatusCode != 200)
                        return null;

                    var file = (Objects.File)res.Data;
                    return ServerUtil.GetImageFromServerUrl(file.Path);
                }
                else
                    return ServerUtil.GetImageFromServerUrl(imageUrl);
            }
            else
            {
                // Draw Image with Letters
                return ImageUtil.DrawLetter(displayName, backgroundColor: color);
            }
        }

        /// <summary>
        ///  Update User
        /// </summary>
        /// <returns></returns>
        public Response Update(Objects.User user)
        {
            //Props
            int statusCode = 200;
            Response response = new Response();
            var color = ColorUtil.ToHEXColor(user.Color);
            var isOnline = Func.ToString(user.IsOnline);
            var isVerified = Func.ToString(user.IsVerified);
            try
            {
                //Open Connection
                Database.Connection.Open();

                //Query
                string query = "UPDATE Users SET Username=@Username, Password=@Password, FirstName=@FirstName, LastName=@LastName, " +
                                    "Email=@Email, PinCode=@PinCode, Role=@Role, Locale=@Locale, Color=@Color, IsOnline=@IsOnline, " +
                                    "IsVerified=@IsVerified " +
                               " WHERE UserId=@UserId";

                //Execute Query With MySqlConnection
                MySqlCommand Command = new MySqlCommand(query, Database.Connection);

                //Parameters For Security Purpose                  
                Command.Parameters.AddWithValue("UserId", user.Id);
                Command.Parameters.AddWithValue("Username", user.Username);
                Command.Parameters.AddWithValue("Password", user.Password);
                Command.Parameters.AddWithValue("FirstName", user.FirstName);
                Command.Parameters.AddWithValue("LastName", user.LastName);
                Command.Parameters.AddWithValue("Email", user.Email);
                Command.Parameters.AddWithValue("PinCode", user.PinCode);
                Command.Parameters.AddWithValue("Role", user.Role);
                Command.Parameters.AddWithValue("Locale", user.Locale);
                Command.Parameters.AddWithValue("Color", color);

                Command.Parameters.AddWithValue("IsOnline", isOnline);
                Command.Parameters.AddWithValue("IsVerified", isVerified);
                Command.ExecuteNonQuery();


                Database.Connection.Close();
                statusCode = 204;
                response.StatusCode = statusCode;
            }
            catch (MySqlException e)
            {
                if (e.Message.Contains("Duplicate entry"))
                    statusCode = 409;
                else
                    // Internal Server Error
                    statusCode = 500;

                Logger.QueryError(e, "User", "Updating User");
                // Status Code
                response.StatusCode = statusCode;
            }
            //Close Connection if Open
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            return response;
        }

        /// <summary>
        ///  Update User Settings
        /// </summary>
        /// <returns></returns>
        public Response UpdateSettings(string userId = null)
        {
            //Props
            int statusCode = 200;
            userId = userId ?? Properties.Settings.Default.UserId;

            var color = ColorUtil.ToHEXColor(Properties.Settings.Default.SoftColor);
            var locale = Properties.Settings.Default.SoftLocale;

            Response response = new Response();
            try
            {
                //Open MySqlConnection
                Database.Connection.Open();

                //Query
                string Query = "UPDATE Users SET Color=@Color, Locale=@Locale WHERE UserId=@UserId";

                //Execute Query With MySqlConnection  => DataReader
                MySqlCommand Command = new MySqlCommand(Query, Database.Connection);

                //Parameters For Security Purpose         
                Command.Parameters.AddWithValue("UserId", userId);

                Command.Parameters.AddWithValue("Color", color);
                Command.Parameters.AddWithValue("Locale", locale);

                Command.ExecuteNonQuery();

                // Close MySqlConnection
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

                Logger.QueryError(e, "User", "Updating Settings");
                // Status Code
                response.StatusCode = statusCode;
            }
            //Close Connection if Open
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            return response;
        }

        /// <summary>
        /// Updates user's imageBlobId 
        /// </summary>
        public Response UpdateImage(Objects.User user, Objects.File file)
        {
            Response response = new Response();
            try
            {
                Database.Connection.Open();

                string Query = " UPDATE Users SET ImageBlobId=@ImageBlobId WHERE UserId=@UserId ";
                MySqlCommand Command = new MySqlCommand(Query, Database.Connection);
                Command.Parameters.AddWithValue("UserId", user.Id);
                Command.Parameters.AddWithValue("ImageBlobId", file.BlobId);
                Command.ExecuteNonQuery();

                Database.Connection.Close();

                // Updated Successfully 
                response.StatusCode = 200;
                response.Data = user;
            }
            catch (MySqlException e)
            {
                Logger.QueryError(e, "User", "Updating Image");
                // Status Code
                response.StatusCode = 500;
            }
            //Close Connection if Open
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            return response;
        }

        /// <summary>
        ///  Delete User
        /// </summary>
        public Response Delete(Objects.User user)
        {
            //Props
            int statusCode = 204;
            user.Id = user.Id ?? Properties.Settings.Default.UserId;
            Response response = new Response();
            try
            {
                //Open Connection
                Database.Connection.Open();

                //Query
                string Query = "DELETE FROM Users WHERE UserId=@UserId ";

                //Execute Query With Connection  => DataReader
                MySqlCommand Command = new MySqlCommand(Query, Database.Connection);
                Command.Parameters.AddWithValue("UserId", user.Id);

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
                Logger.QueryError(e, "User", "Getting User");
                // Internal Error :
                response.StatusCode = 500;
            }
            //Close Connection if Open
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            return response;
        }

        /// <summary>
        /// Get User Role Count
        /// </summary>
        /// <returns></returns>
        public Response GetUserRoleCount(string role)
        {
            Response response = new Response();
            try
            {
                //Open Connection
                Database.Connection.Open();

                string Query = "SELECT COUNT(*) FROM Users WHERE Role=@Role";
                MySqlCommand Command = new MySqlCommand(Query, Database.Connection);

                Command.Parameters.AddWithValue("Role", role);

                //Response 
                response.IntegerData = Func.GetRowsCount(Command);
                response.StatusCode = 200;

                //Close Connection
                Database.Connection.Close();
            }
            catch (MySqlException e)
            {
                Logger.QueryError(e, "User", "Getting User Role Counts");
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

#region Query Backup : 

/** 
       // Today
                // SELECT SUM(TotalPrice) AS DailyRevenue FROM Sales WHERE(UserId = 'QEmnHlbZWXTmvBAa8AND' AND SoldAt BETWEEN CURRENT_DATE() AND(NOW() + INTERVAL 1 DAY))
                // Week
                // SELECT SUM(TotalPrice) AS  WeeklyRevenue  FROM Sales WHERE (UserId = 'QEmnHlbZWXTmvBAa8AND' AND EXTRACT(WEEK FROM SoldAt) = 43  )
                // Month
                //SELECT SUM(TotalPrice) AS MonthlyRevenue FROM Sales WHERE(UserId = 'QEmnHlbZWXTmvBAa8AND' AND  EXTRACT(YEAR_MONTH FROM SoldAt) = 201810)
                // This Year
                //SELECT SUM(TotalPrice) AS YearlyRevenue FROM Sales WHERE(UserId = 'QEmnHlbZWXTmvBAa8AND' AND YEAR(SoldAt) = '2018')
                // Total
                // SELECT SUM(TotalPrice) AS TotalRevenue FROM Sales WHERE (UserId =@UserId )

 * **/

#endregion