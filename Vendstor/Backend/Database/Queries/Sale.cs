using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Data;

// Vendstor
using Vendstor.Backend.Utils;
using Vendstor.Backend.Constants;
using Vendstor.Backend.Data;

/** 
 * Copyright : © RigleSoft™,  Rigle™ - A Company of Franz Nkemaka™ -  All Rights Reserved 
 * Read README for more information. */

namespace Vendstor.Backend.Database.Queries
{
    public class Sale : Query
    {
        /// <summary>
        /// Checks if Id is valid
        /// </summary>       
        /// <returns></returns>
        public bool IsValid(Objects.Sale sale)
        {
            bool isValid;
            try
            {
                //Open Connection
                Database.Connection.Open();

                string query = "SELECT SaleId FROM Sales WHERE SaleId=@SaleId";
                MySqlCommand Command = new MySqlCommand(query, Database.Connection);
                Command.Parameters.AddWithValue("SaleId", sale.Id);
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
                Logger.QueryError(e, "Sale", "Verifying Id");
                isValid = false;
            }

            //Close Connection if Open
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            return isValid;
        }

        /// <summary>
        /// Create a new Sale
        /// </summary>
        /// <returns></returns>
        public Response Create(Objects.Sale sale)
        {
            int statusCode = 201;
            Response response = new Response();
            var isDiscounted = Func.ToString(sale.IsDiscounted);
            var isGuest = Func.ToString(sale.IsGuest);
            try
            {
                Database.Connection.Open();

                string query = " INSERT INTO Sales (SaleId, UserId, CustomerId, Note, DiscountName, DiscountPercentage, " +
                                         "ItemsCount, SupplyPrice, SubTotalPrice, DiscountPrice, TaxAmount, PaymentMethod, Paid, Balance, " +
                                         "TotalPrice, IsDiscounted, IsGuest ) " +
                               " VALUES (@SaleId, @UserId, @CustomerId, @Note, @DiscountName, @DiscountPercentage, @ItemsCount, @SupplyPrice, " +
                                        " @SubTotalPrice, @DiscountPrice,  @TaxAmount,  @PaymentMethod,  @Paid,  @Balance, " +
                                        " @TotalPrice, @IsDiscounted, @IsGuest) ";

                MySqlCommand Command = new MySqlCommand(query, Database.Connection);

                Command.Parameters.AddWithValue("SaleId", sale.Id);
                Command.Parameters.AddWithValue("UserId", sale.User.Id);
                Command.Parameters.AddWithValue("CustomerId", sale.Customer.Id);
                Command.Parameters.AddWithValue("Note", sale.Note);
                Command.Parameters.AddWithValue("DiscountName", sale.DiscountName);
                Command.Parameters.AddWithValue("DiscountPercentage", sale.DiscountPercentage);
                Command.Parameters.AddWithValue("ItemsCount", sale.ItemsCount);

                Command.Parameters.AddWithValue("SupplyPrice", sale.SupplyPrice);
                Command.Parameters.AddWithValue("SubTotalPrice", sale.SubTotalPrice);
                Command.Parameters.AddWithValue("DiscountPrice", sale.DiscountPrice);
                Command.Parameters.AddWithValue("TaxAmount", sale.TaxAmount);
                Command.Parameters.AddWithValue("TotalPrice", sale.TotalPrice);

                Command.Parameters.AddWithValue("PaymentMethod", sale.PaymentMethod);
                Command.Parameters.AddWithValue("Paid", sale.Paid);
                Command.Parameters.AddWithValue("Balance", sale.Balance);

                Command.Parameters.AddWithValue("IsDiscounted", isDiscounted);
                Command.Parameters.AddWithValue("IsGuest", isGuest);
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
                Logger.QueryError(e, "Sale", "Create");
            }
            //Close Connection if Open
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            //Response
            response.StatusCode = statusCode;
            response.Data = sale;

            return response;
        }

        /// <summary>
        /// Get 
        /// </summary>
        /// <returns></returns>
        public Response Get(Objects.Sale sale)
        {
            int statusCode = 200;
            Response response = new Response();
            try
            {
                Database.Connection.Open();

                string Query = "SELECT * FROM Sales WHERE SaleId=@SaleId";
                //Execute Query 
                MySqlCommand Command = new MySqlCommand(Query, Database.Connection);
                Command.Parameters.AddWithValue("SaleId", sale.Id);
                MySqlDataReader DataReader = Command.ExecuteReader();

                //Read Data
                while (DataReader.Read())
                {
                    sale.Id = DataReader["SaleId"].ToString();
                    sale.Note = DataReader["Note"].ToString();
                    sale.DiscountName = DataReader["DiscountName"].ToString();
                    sale.DiscountAmount = decimal.Parse(DataReader["DiscountAmount"].ToString());
                    sale.DiscountPercentage = decimal.Parse(DataReader["DiscountPercentage"].ToString());
                    sale.ItemsCount = int.Parse(DataReader["ItemsCount"].ToString());

                    sale.SupplyPrice = decimal.Parse(DataReader["SupplyPrice"].ToString());
                    sale.SubTotalPrice = decimal.Parse(DataReader["SubTotalPrice"].ToString());
                    sale.DiscountPrice = decimal.Parse(DataReader["DiscountPrice"].ToString());
                    sale.TaxAmount = decimal.Parse(DataReader["TaxAmount"].ToString());
                    sale.TotalPrice = decimal.Parse(DataReader["TotalPrice"].ToString());

                    sale.PaymentMethod = DataReader["PaymentMethod"].ToString();
                    sale.Paid = decimal.Parse(DataReader["Paid"].ToString());
                    sale.Balance = decimal.Parse(DataReader["Balance"].ToString());

                    sale.IsDiscounted = Func.ToBoolean(DataReader["IsDiscounted"].ToString());
                    sale.IsGuest = Func.ToBoolean(DataReader["IsGuest"].ToString());

                    sale.User = new Objects.User { Id = DataReader["UserId"].ToString() };
                    sale.Customer = new Objects.Customer { Id = DataReader["CustomerId"].ToString() };

                    sale.UpdatedAt = Convert.ToDateTime(DataReader["UpdatedAt"].ToString());
                    sale.SoldAt = Convert.ToDateTime(DataReader["SoldAt"].ToString());

                    sale.IsFetchItem = true;
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
                response.Data = sale;
            }
            catch (MySqlException e)
            {
                Logger.QueryError(e, "Sale", "Get");
                // Internal Error :
                response.StatusCode = 500;
            }
            //Close Connection if Open
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            return response;
        }

        private string GetSearchQuery(Objects.SaleSearchQuery searchQuery)
        {
            var query = " SELECT * FROM Sales ";
            var append = " ORDER BY SoldAt DESC ";
            switch (searchQuery.Type)
            {
                case Enums.SearchQueryType.None:
                    return query + append;

                case Enums.SearchQueryType.Id:
                    return query + " WHERE  UserId=@UserId" + append;

                case Enums.SearchQueryType.DateRange:
                    return query + " WHERE  SoldAt BETWEEN @DateFrom AND @DateTo " + append;

                default:
                    return query + append;
            }
        }

        private string GetTaxesSearchQuery(Objects.SaleSearchQuery searchQuery)
        {
            var query = " SELECT SUM(TaxAmount) AS TaxAmount, SUM(TotalPrice) AS TotalPrice  FROM Sales  ";
            switch (searchQuery.Type)
            {
                case Enums.SearchQueryType.None:
                    return query;
                case Enums.SearchQueryType.DateRange:
                    return query + " WHERE  SoldAt BETWEEN @DateFrom AND @DateTo ";
                default:
                    return query;
            }
        }

        private string GetPaymentsSearchQuery(Objects.SaleSearchQuery searchQuery)
        {
            var query = " SELECT SUM(TotalPrice) AS PaidAmount, PaymentMethod, SoldAt FROM Sales ";
            var append = "  GROUP BY SoldAt";
            switch (searchQuery.Type)
            {
                case Enums.SearchQueryType.None:
                    return query + append;
                case Enums.SearchQueryType.DateRange:
                    return query + " WHERE  SoldAt BETWEEN @DateFrom AND @DateTo " + append;
                default:
                    return query + append;
            }
        }

        private string GetSalesLegersSearchQuery(Objects.SaleSearchQuery searchQuery)
        {
            var query = " SELECT * FROM Sales ";
            var append = " ORDER BY SoldAt DESC ";
            switch (searchQuery.Type)
            {
                case Enums.SearchQueryType.None:
                    return query + append;

                case Enums.SearchQueryType.Query:
                    return query + " WHERE ( SaleId LIKE @SearchQuery OR NOTE LIKE @SearchQuery ) " + append;

                case Enums.SearchQueryType.Customer:
                    return query + " WHERE  CustomerId=@CustomerId" + append;

                case Enums.SearchQueryType.User:
                    return query + " WHERE  UserId=@UserId" + append;

                case Enums.SearchQueryType.DateRange:
                    return query + " WHERE  SoldAt BETWEEN @DateFrom AND @DateTo " + append;

                default:
                    return query + append;
            }
        }

        /// <summary>
        /// Get Sales
        /// </summary>
        /// <returns></returns>
        public Response GetSales(Objects.SaleSearchQuery searchQuery, Objects.Pagination pagination)
        {
            int statusCode = 200;
            Response response = new Response();
            List<object> sales = new List<object>();
            try
            {
                Database.Connection.Open();
                var query = GetSearchQuery(searchQuery) + Func.GetPaginationLimit(pagination);

                //Execute Query 
                MySqlCommand Command = new MySqlCommand(query, Database.Connection);
                Command.Parameters.AddWithValue("UserId", searchQuery.UserId);
                Command.Parameters.AddWithValue("DateFrom", searchQuery.DateFrom);
                Command.Parameters.AddWithValue("DateTo", searchQuery.DateTo);
                MySqlDataReader DataReader = Command.ExecuteReader();

                //Read Data
                while (DataReader.Read())
                {
                    Objects.Sale sale = new Objects.Sale
                    {
                        Id = DataReader["SaleId"].ToString(),
                        Note = DataReader["Note"].ToString(),
                        DiscountName = DataReader["DiscountName"].ToString(),
                        DiscountAmount = decimal.Parse(DataReader["DiscountAmount"].ToString()),
                        DiscountPercentage = decimal.Parse(DataReader["DiscountPercentage"].ToString()),
                        ItemsCount = int.Parse(DataReader["ItemsCount"].ToString()),

                        SupplyPrice = decimal.Parse(DataReader["SupplyPrice"].ToString()),
                        SubTotalPrice = decimal.Parse(DataReader["SubTotalPrice"].ToString()),
                        DiscountPrice = decimal.Parse(DataReader["DiscountPrice"].ToString()),
                        TaxAmount = decimal.Parse(DataReader["TaxAmount"].ToString()),
                        TotalPrice = decimal.Parse(DataReader["TotalPrice"].ToString()),

                        PaymentMethod = DataReader["PaymentMethod"].ToString(),
                        Paid = decimal.Parse(DataReader["Paid"].ToString()),
                        Balance = decimal.Parse(DataReader["Balance"].ToString()),

                        IsDiscounted = Func.ToBoolean(DataReader["IsDiscounted"].ToString()),
                        IsGuest = Func.ToBoolean(DataReader["IsGuest"].ToString()),

                        User = new Objects.User { Id = DataReader["UserId"].ToString() },
                        Customer = new Objects.Customer { Id = DataReader["CustomerId"].ToString() },

                        UpdatedAt = Convert.ToDateTime(DataReader["UpdatedAt"].ToString()),
                        SoldAt = Convert.ToDateTime(DataReader["SoldAt"].ToString()),
                        IsFetchItem = true,
                    };

                    sales.Add(sale);
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
                response.DataArray = sales;
                response.Pagination = pagination;
            }
            catch (MySqlException e)
            {
                Logger.QueryError(e, "Sale", "Getting Sales");
                // Internal Error :
                response.StatusCode = 500;
            }
            //Close Connection if Open
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            return response;
        }

        /// <summary>
        /// Sum Taxes
        /// </summary>
        /// <returns></returns>
        public Response SumTaxes(Objects.SaleSearchQuery searchQuery)
        {
            int statusCode = 200;
            Response response = new Response();
            IDictionary<string, decimal> data = new Dictionary<string, decimal>();
            try
            {
                Database.Connection.Open();
                var query = GetTaxesSearchQuery(searchQuery);

                //Execute Query 
                MySqlCommand Command = new MySqlCommand(query, Database.Connection);
                Command.Parameters.AddWithValue("DateFrom", searchQuery.DateFrom);
                Command.Parameters.AddWithValue("DateTo", searchQuery.DateTo);
                MySqlDataReader DataReader = Command.ExecuteReader();

                //Read Data
                while (DataReader.Read())
                {
                    data.Add("TaxAmount", Func.ToDecimal(DataReader["TaxAmount"].ToString()));
                    data.Add("TotalPrice", Func.ToDecimal(DataReader["TotalPrice"].ToString()));
                }
                if (!DataReader.HasRows)
                    statusCode = 204;
                else
                    // OK 
                    statusCode = 200;

                Database.Connection.Close();

                //Response 
                response.StatusCode = statusCode;
                response.Data = data;
            }
            catch (MySqlException e)
            {
                Logger.QueryError(e, "Sale", "Summing Taxes");
                // Internal Error :
                response.StatusCode = 500;
            }
            //Close Connection if Open
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            return response;
        }

        /// <summary>
        /// Get Payments
        /// </summary>
        /// <returns></returns>
        public Response GetPayments(Objects.SaleSearchQuery searchQuery, Objects.Pagination pagination)
        {
            int statusCode = 200;
            Response response = new Response();
            List<object> payments = new List<object>();

            try
            {
                Database.Connection.Open();
                var query = GetPaymentsSearchQuery(searchQuery) + Func.GetPaginationLimit(pagination);
                //Execute Query 
                MySqlCommand Command = new MySqlCommand(query, Database.Connection);
                Command.Parameters.AddWithValue("DateFrom", searchQuery.DateFrom);
                Command.Parameters.AddWithValue("DateTo", searchQuery.DateTo);
                MySqlDataReader DataReader = Command.ExecuteReader();

                //Read Data
                while (DataReader.Read())
                {
                    Objects.Payment payment = new Objects.Payment
                    {
                        PaidAmount = decimal.Parse(DataReader["PaidAmount"].ToString()),
                        Method = DataReader["PaymentMethod"].ToString(),
                        PaidAt = Convert.ToDateTime(DataReader["SoldAt"].ToString()),
                    };
                    payments.Add(payment);
                }
                if (!DataReader.HasRows)
                    statusCode = 204;
                else
                    // OK 
                    statusCode = 200;

                Database.Connection.Close();

                //Response 
                response.StatusCode = statusCode;
                response.DataArray = payments;
                response.Pagination = pagination;
            }
            catch (MySqlException e)
            {
                Logger.QueryError(e, "Sale", "Getting Payments");
                // Internal Error :
                response.StatusCode = 500;
            }
            //Close Connection if Open
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            return response;
        }

        /// <summary>
        /// Get SaleLedgers
        /// </summary>
        /// <returns></returns>
        public Response GetSaleLedgers(Objects.SaleSearchQuery searchQuery, Objects.Pagination pagination)
        {
            int statusCode = 200;
            Response response = new Response();
            List<object> sales = new List<object>();
            try
            {
                Database.Connection.Open();
                var q = "%" + searchQuery.Query + "%";
                var query = GetSalesLegersSearchQuery(searchQuery) + Func.GetPaginationLimit(pagination);

                //Execute Query 
                MySqlCommand Command = new MySqlCommand(query, Database.Connection);
                Command.Parameters.AddWithValue("SearchQuery", q);
                Command.Parameters.AddWithValue("UserId", searchQuery.UserId);
                Command.Parameters.AddWithValue("CustomerId", searchQuery.CustomerId);
                Command.Parameters.AddWithValue("DateFrom", searchQuery.DateFrom);
                Command.Parameters.AddWithValue("DateTo", searchQuery.DateTo);
                MySqlDataReader DataReader = Command.ExecuteReader();

                //Read Data
                while (DataReader.Read())
                {
                    Objects.Sale sale = new Objects.Sale
                    {
                        Id = DataReader["SaleId"].ToString(),
                        Note = DataReader["Note"].ToString(),
                        DiscountName = DataReader["DiscountName"].ToString(),
                        DiscountAmount = decimal.Parse(DataReader["DiscountAmount"].ToString()),
                        DiscountPercentage = decimal.Parse(DataReader["DiscountPercentage"].ToString()),
                        ItemsCount = int.Parse(DataReader["ItemsCount"].ToString()),

                        SupplyPrice = decimal.Parse(DataReader["SupplyPrice"].ToString()),
                        SubTotalPrice = decimal.Parse(DataReader["SubTotalPrice"].ToString()),
                        DiscountPrice = decimal.Parse(DataReader["DiscountPrice"].ToString()),
                        TaxAmount = decimal.Parse(DataReader["TaxAmount"].ToString()),
                        TotalPrice = decimal.Parse(DataReader["TotalPrice"].ToString()),

                        PaymentMethod = DataReader["PaymentMethod"].ToString(),
                        Paid = decimal.Parse(DataReader["Paid"].ToString()),
                        Balance = decimal.Parse(DataReader["Balance"].ToString()),

                        IsDiscounted = Func.ToBoolean(DataReader["IsDiscounted"].ToString()),
                        IsGuest = Func.ToBoolean(DataReader["IsGuest"].ToString()),

                        User = new Objects.User { Id = DataReader["UserId"].ToString() },
                        Customer = new Objects.Customer { Id = DataReader["CustomerId"].ToString() },

                        UpdatedAt = Convert.ToDateTime(DataReader["UpdatedAt"].ToString()),
                        SoldAt = Convert.ToDateTime(DataReader["SoldAt"].ToString()),
                        IsFetchItem = true,
                    };

                    sales.Add(sale);
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
                response.DataArray = sales;
                response.Pagination = pagination;
            }
            catch (MySqlException e)
            {
                Logger.QueryError(e, "Sale", "Getting Sale Ledgers");
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
        ///  </summary>
        public Response Update(Objects.Sale sale)
        {
            return new Response();
        }

        /// <summary>
        ///  Delete 
        /// </summary>
        public Response Delete(Objects.Sale sale)
        {
            //Props
            int statusCode = 204;
            Response response = new Response();
            try
            {
                Database.Connection.Open();

                string Query = "DELETE FROM Sales WHERE SaleId=@SaleId ";
                //Execute Query With Connection  => DataReader
                MySqlCommand Command = new MySqlCommand(Query, Database.Connection);
                Command.Parameters.AddWithValue("SaleId", sale.Id);

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
                Logger.QueryError(e, "Sale", "Delete ");
                // Internal Error :
                response.StatusCode = 500;
            }
            //Close Connection if Open
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            return response;
        }

        /// <summary>
        /// Add a Item to a Sale
        /// </summary>
        /// <returns></returns>
        public Response AddItem(Objects.SaleItem item, Objects.Sale sale)
        {
            int statusCode = 201;
            Response response = new Response();
            item.Id = ServerUtil.GenerateToken(TokenLengths.TokensLength);
            try
            {
                Database.Connection.Open();

                string query = " INSERT INTO SaleItems (SaleItemId, SaleId, ProductId, DiscountId, Quantity, SupplyPrice, Price, DiscountPrice, TaxAmount, " +
                                    " TotalPrice, Note, Status, IsDiscounted, IsBalanceRequired )" +
                               " VALUES (@SaleItemId,@SaleId, @ProductId, @DiscountId, @Quantity, @SupplyPrice, @Price, @DiscountPrice, @TaxAmount, " +
                                    " @TotalPrice, @Note, @Status, @IsDiscounted, @IsBalanceRequired ) ";

                MySqlCommand Command = new MySqlCommand(query, Database.Connection);
                Command.Parameters.AddWithValue("SaleItemId", item.Id);
                Command.Parameters.AddWithValue("SaleId", sale.Id);
                Command.Parameters.AddWithValue("ProductId", item.Product.Id);
                Command.Parameters.AddWithValue("DiscountId", item.Discount.Id);
                Command.Parameters.AddWithValue("Quantity", item.Quantity);

                Command.Parameters.AddWithValue("SupplyPrice", item.SupplyPrice);
                Command.Parameters.AddWithValue("Price", item.Price);
                Command.Parameters.AddWithValue("DiscountPrice", item.DiscountPrice);
                Command.Parameters.AddWithValue("TaxAmount", item.TaxAmount);
                Command.Parameters.AddWithValue("TotalPrice", item.TotalPrice);

                Command.Parameters.AddWithValue("Note", item.Note);
                Command.Parameters.AddWithValue("Status", item.Status);

                Command.Parameters.AddWithValue("IsDiscounted", Func.ToString(item.IsDiscounted));
                Command.Parameters.AddWithValue("IsBalanceRequired", Func.ToString(item.IsBalanceRequired));

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
                Logger.QueryError(e, "Sale", "AddProduct");

            }
            //Close Connection if Open
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            //Response

            response.StatusCode = statusCode;
            response.Data = item;

            return response;
        }

        /// <summary>
        /// Get Item of Sale
        /// </summary>
        /// <returns></returns>
        public Response GetSaleItems(Objects.Sale sale)
        {
            int statusCode = 200;
            Response response = new Response();
            List<object> items = new List<object>();
            try
            {
                Database.Connection.Open();
                string query = " SELECT * FROM SaleItems WHERE SaleId=@SaleId ORDER BY CreatedAt DESC ";
                //Execute Query 
                MySqlCommand Command = new MySqlCommand(query, Database.Connection);
                Command.Parameters.AddWithValue("SaleId", sale.Id);
                MySqlDataReader DataReader = Command.ExecuteReader();

                //Read Data
                while (DataReader.Read())
                {
                    Objects.SaleItem item = new Objects.SaleItem
                    {
                        Id = DataReader["SaleItemId"].ToString(),
                        SaleId = DataReader["SaleId"].ToString(),
                        Note = DataReader["Note"].ToString(),
                        Status = DataReader["Status"].ToString(),

                        Quantity = decimal.Parse(DataReader["Quantity"].ToString()),
                        DiscountPrice = decimal.Parse(DataReader["DiscountPrice"].ToString()),
                        Price = decimal.Parse(DataReader["Price"].ToString()),
                        TaxAmount = decimal.Parse(DataReader["TaxAmount"].ToString()),
                        TotalPrice = decimal.Parse(DataReader["TotalPrice"].ToString()),

                        IsDiscounted = Func.ToBoolean(DataReader["IsDiscounted"].ToString()),

                        Product = new Objects.Product { Id = DataReader["ProductId"].ToString() },
                        Discount = new Objects.Discount { Id = DataReader["DiscountId"].ToString() },

                        SoldAt = Convert.ToDateTime(DataReader["CreatedAt"].ToString()),

                        IsFetchItem = true,
                    };
                    items.Add(item);
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
                response.DataArray = items;
            }
            catch (MySqlException e)
            {
                Logger.QueryError(e, "Sale", "Getting Sale Items");
                // Internal Error :
                response.StatusCode = 500;
            }
            //Close Connection if Open
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            return response;
        }

        /// <summary>
        /// Remove a Item from Sale
        /// </summary>
        /// <returns></returns>
        public Response RemoveItem(Objects.SaleItem item)
        {
            int statusCode = 204;
            Response response = new Response();
            try
            {
                Database.Connection.Open();

                string Query = "DELETE FROM SaleItems WHERE SaleItemId=@SaleItemId ";
                MySqlCommand Command = new MySqlCommand(Query, Database.Connection);
                Command.Parameters.AddWithValue("SaleItemId", item.Id);
                Command.ExecuteNonQuery();

                Database.Connection.Close();

                // OK : Successfully Deleted -> Returning No Content    
                statusCode = 204;
                response.StatusCode = statusCode;
            }
            catch (MySqlException e)
            {
                Logger.QueryError(e, "Sale", "Remove Item");
                // Internal Error :
                response.StatusCode = 500;
            }
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            return response;
        }
    }
}
