using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

// Vendstor
using Vendstor.Backend.Data;
using Vendstor.Backend.Utils;
using Vendstor.Backend.Constants;
using Vendstor.Backend.Libraries;

/** 
* Copyright : © RigleSoft™,  Rigle™ - A Company of Franz Nkemaka™ -  All Rights Reserved 
* Read README for more information. */

namespace Vendstor.Backend.Database.Queries
{
    public class Product : Query
    {
        /// <summary>
        /// Checks if Id is valid
        /// </summary>       
        /// <returns></returns>
        public bool IsValid(Objects.Product product)
        {
            bool isValid;
            try
            {
                //Open Connection
                Database.Connection.Open();

                string query = "SELECT ProductId FROM Products WHERE ProductId=@ProductId";
                MySqlCommand Command = new MySqlCommand(query, Database.Connection);
                Command.Parameters.AddWithValue("ProductId", product.Id);
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
                Logger.QueryError(e, "Product", "Verifying Id");
                isValid = false;
            }

            //Close Connection if Open
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            return isValid;
        }

        /// <summary>
        /// Create a new Product
        /// </summary>
        /// <returns></returns>
        public Response Create(Objects.Product product)
        {
            //Props
            int statusCode = 201;
            Response response = new Response();
            //Random Tokens
            product.Id = ServerUtil.GenerateToken(TokenLengths.ProductIdLength);
            var color = ColorUtil.ToHEXColor(product.Color);
            var isBalanceRequired = Func.ToString(product.IsBalanceRequired);
            try
            {
                //Database.Reconnect();
                Database.Connection.Open();
                var query = " INSERT INTO Products (ProductId, Barcode, Name, Description, Stock, IsBalanceRequired, SupplyPrice, RetailPrice, Markup," +
                                                        " TaxId, TypeId, BrandId, SupplierId, ImageBlobId, Color) " +
                               " VALUES (@ProductId, @Barcode, @Name, @Description, @Stock, @IsBalanceRequired, @SupplyPrice, @RetailPrice, @Markup," +
                                                        " @TaxId, @TypeId, @BrandId, @SupplierId, @ImageBlobId, @Color) ";
                MySqlCommand Command = new MySqlCommand(query, Database.Connection);

                Command.Parameters.AddWithValue("ProductId", product.Id);
                Command.Parameters.AddWithValue("Barcode", product.Barcode);
                Command.Parameters.AddWithValue("Name", product.Name);
                Command.Parameters.AddWithValue("Description", product.Description);
                Command.Parameters.AddWithValue("Stock", product.Stock);
                Command.Parameters.AddWithValue("IsBalanceRequired", isBalanceRequired);
                Command.Parameters.AddWithValue("SupplyPrice", product.SupplyPrice);
                Command.Parameters.AddWithValue("RetailPrice", product.RetailPrice);
                Command.Parameters.AddWithValue("Markup", product.Markup);
                Command.Parameters.AddWithValue("Color", color);

                Command.Parameters.AddWithValue("TaxId", product.Tax.Id);
                Command.Parameters.AddWithValue("TypeId", product.Type.Id);
                Command.Parameters.AddWithValue("BrandId", product.Brand.Id);
                Command.Parameters.AddWithValue("SupplierId", product.Supplier.Id);
                Command.Parameters.AddWithValue("ImageBlobId", product.ImageBlobId);

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
                Logger.QueryError(e, "Product", "Create");

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
        /// Get Product 
        /// </summary>
        public Response Get(Objects.Product product, bool isSellItem = false)
        {
            //Props
            int statusCode = 200;
            Response response = new Response();
            string taxId = null, typeId = null, brandId = null, supplierId = null;
            try
            {
                Database.Connection.Open();

                var noramlQuery = "SELECT * FROM Products WHERE (ProductId=@ProductId OR  Barcode=@Barcode)";
                var sellItemQuery = " SELECT DISTINCT Products.*, ProductDiscounts.DiscountId,  " +
                      " IF(ProductDiscounts.DiscountId IS NOT NULL AND " +
                      "       ( NOW() BETWEEN( SELECT Discounts.StartDate FROM Discounts " +
                      "       WHERE Discounts.DiscountId = ProductDiscounts.DiscountId )   " +
                      "       AND( SELECT Discounts.EndDate FROM Discounts WHERE Discounts.DiscountId = ProductDiscounts.DiscountId))," +
                      "       TRUE, FALSE) " +
                      " AS IsDiscounted FROM Products " +

                      " LEFT JOIN ProductDiscounts " +
                      "   ON(Products.ProductId = ProductDiscounts.ProductId) " +
                      " LEFT JOIN Discounts " +
                      "   ON(Discounts.DiscountId = ProductDiscounts.DiscountId) " +
                      " WHERE (Products.ProductId=@ProductId OR  Products.Barcode=@Barcode) ";

                var query = (isSellItem) ? sellItemQuery : noramlQuery;

                //Execute Query 
                MySqlCommand Command = new MySqlCommand(query, Database.Connection);
                Command.Parameters.AddWithValue("ProductId", product.Id);
                Command.Parameters.AddWithValue("Barcode", product.Barcode);
                MySqlDataReader DataReader = Command.ExecuteReader();

                //Read Data
                while (DataReader.Read())
                {
                    product.Id = DataReader["ProductId"].ToString();
                    product.Barcode = DataReader["Barcode"].ToString();
                    product.Name = DataReader["Name"].ToString();
                    product.Description = DataReader["Description"].ToString();

                    product.Stock = Func.ToDecimal(DataReader["Stock"].ToString());
                    product.IsBalanceRequired = Func.ToBoolean(DataReader["IsBalanceRequired"].ToString());

                    if (isSellItem)
                    {
                        product.IsDiscounted = Func.ToBoolean(DataReader["IsDiscounted"].ToString());
                        product.Discount = new Objects.DiscountProduct
                        {
                            DiscountId = DataReader["DiscountId"].ToString(),
                            ProductId = DataReader["ProductId"].ToString(),
                        };
                    }

                    product.SupplyPrice = Func.ToDecimal(DataReader["SupplyPrice"].ToString());
                    product.RetailPrice = Func.ToDecimal(DataReader["RetailPrice"].ToString());
                    product.Markup = Func.ToDecimal(DataReader["Markup"].ToString());
                    product.ImageBlobId = DataReader["ImageBlobId"].ToString();
                    product.Color = ColorUtil.HEXToColor(DataReader["Color"].ToString());

                    product.UpdatedAt = Convert.ToDateTime(DataReader["UpdatedAt"].ToString());
                    product.CreatedAt = Convert.ToDateTime(DataReader["CreatedAt"].ToString());

                    taxId = DataReader["TaxId"].ToString();
                    typeId = DataReader["TaxId"].ToString();
                    brandId = DataReader["TaxId"].ToString();
                    supplierId = DataReader["TaxId"].ToString();
                }
                if (!DataReader.HasRows)
                    // Bad Request 
                    statusCode = 400;
                else
                    // OK 
                    statusCode = 200;

                //Close Connection
                Database.Connection.Close();

                if (statusCode == 200)
                    product.Image = GetImage(product.ImageBlobId, product.Name, product.Color);

                // Get Objects 
                product.Type = ProductType.GetTypeById(typeId);
                product.Brand = ProductBrand.GetBrand(brandId);
                product.Supplier = ProductSupplier.GetSupplier(supplierId);
                product.Tax = Tax.GetTax(taxId);

                //Response 
                response.StatusCode = statusCode;
                response.Data = product;
            }
            catch (MySqlException e)
            {
                Logger.QueryError(e, "Product", "Getting Product");
                // Internal Error :
                response.StatusCode = 500;
            }
            //Close Connection if Open
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            return response;
        }

        public static Image GetImage(string imageBlobId, string productName, Color color, bool doRequest = true, string imageUrl = null)
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
                return ImageUtil.DrawLetter(productName, backgroundColor: color);
            }
        }

        private string GetSearchQuery(Objects.ProductSearchQuery searchQuery, bool hasLimit = false)
        {
            var append = (hasLimit) ? "  LIMIT @Limit" : null;
            var defaultQuery = " SELECT * FROM Products ORDER BY CreatedAt DESC " + append;
            switch (searchQuery.Type)
            {
                case Enums.SearchQueryType.None:
                    return defaultQuery;

                case Enums.SearchQueryType.Query:
                    return " SELECT DISTINCT * FROM Products WHERE (Name LIKE @SearchQuery OR Description LIKE @SearchQuery ) ORDER BY CreatedAt DESC" + append;

                case Enums.SearchQueryType.Id:
                    return " SELECT DISTINCT * FROM Products WHERE (SupplierId=@SupplierId OR BrandId=@BrandId OR TypeId=@TypeId) " + append;

                default:
                    return defaultQuery;
            }
        }

        /// <summary>
        /// Get Products
        /// </summary>
        /// <returns></returns>
        public Response GetProducts(Objects.ProductSearchQuery searchQuery, int limit = 0)
        {
            int statusCode = 200;
            Response response = new Response();
            List<object> products = new List<object>();
            try
            {
                Database.Connection.Open();

                var q = $"%{searchQuery.Query}%";
                var query = GetSearchQuery(searchQuery, limit != 0);

                //Execute Query 
                MySqlCommand Command = new MySqlCommand(query, Database.Connection);
                Command.Parameters.AddWithValue("SearchQuery", q);
                Command.Parameters.AddWithValue("SupplierId", searchQuery.SupplierId);
                Command.Parameters.AddWithValue("BrandId", searchQuery.BrandId);
                Command.Parameters.AddWithValue("TypeId", searchQuery.TypeId);
                Command.Parameters.AddWithValue("Status", searchQuery.Status);
                Command.Parameters.AddWithValue("Limit", limit);
                MySqlDataReader DataReader = Command.ExecuteReader();

                //Read Data
                while (DataReader.Read())
                {
                    Objects.Product product = new Objects.Product
                    {
                        Id = DataReader["ProductId"].ToString(),
                        Barcode = DataReader["Barcode"].ToString(),
                        Name = DataReader["Name"].ToString(),
                        Description = DataReader["Description"].ToString(),

                        Stock = Func.ToDecimal(DataReader["Stock"].ToString()),
                        IsBalanceRequired = Func.ToBoolean(DataReader["IsBalanceRequired"].ToString()),
                        SupplyPrice = Func.ToDecimal(DataReader["SupplyPrice"].ToString()),
                        RetailPrice = Func.ToDecimal(DataReader["RetailPrice"].ToString()),
                        Markup = Func.ToDecimal(DataReader["Markup"].ToString()),
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
                Logger.QueryError(e, "Product", "Getting Products");
                // Internal Error :
                response.StatusCode = 500;
            }
            //Close Connection if Open
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            return response;
        }

        private string GetSellSearchQuery(Objects.ProductSearchQuery searchQuery, bool hasLimit = false)
        {
            var query = " SELECT DISTINCT Products.*, ProductDiscounts.DiscountId,  " +
                        " IF(ProductDiscounts.DiscountId IS NOT NULL AND " +
                        "       ( NOW() BETWEEN( SELECT Discounts.StartDate FROM Discounts " +
                        "       WHERE Discounts.DiscountId = ProductDiscounts.DiscountId )   " +
                        "       AND( SELECT Discounts.EndDate FROM Discounts WHERE Discounts.DiscountId = ProductDiscounts.DiscountId))," +
                        "       TRUE, FALSE) " +
                        " AS IsDiscounted FROM Products " +

                        " LEFT JOIN ProductDiscounts " +
                        "   ON(Products.ProductId = ProductDiscounts.ProductId) " +
                        " LEFT JOIN Discounts " +
                        "   ON(Discounts.DiscountId = ProductDiscounts.DiscountId)";

            /** Old Query
            var oldQuery = "SELECT DISTINCT Products.*, ProductDiscounts.DiscountId, " +
                        "IF(ProductDiscounts.DiscountId IS NULL, FALSE, TRUE) AS IsDiscounted FROM Products " +
                        "LEFT JOIN ProductDiscounts " +
                        "ON(Products.ProductId = ProductDiscounts.ProductId) ";*/

            var append = " ORDER BY CreatedAt DESC ";
            append += (hasLimit) ? "  LIMIT @Limit" : null;

            var defaultQuery = query + append;

            switch (searchQuery.Type)
            {
                case Enums.SearchQueryType.None:
                    return defaultQuery;

                case Enums.SearchQueryType.Query:
                    return query + " WHERE (Products.Barcode LIKE @SearchQuery OR Products.Name LIKE @SearchQuery OR Products.Description LIKE @SearchQuery ) " + append;

                case Enums.SearchQueryType.Barcode:
                    return query + " WHERE Barcode=@Barcode " + append;

                default:
                    return defaultQuery;
            }
        }

        /// <summary>
        /// Get Sell Products
        /// </summary>
        /// <returns></returns>
        public Response GetSellProducts(Objects.ProductSearchQuery searchQuery, int limit = 0)
        {
            int statusCode = 200;
            Response response = new Response();
            List<object> products = new List<object>();
            try
            {
                Database.Connection.Open();

                var q = $"%{searchQuery.Query}%";
                var query = GetSellSearchQuery(searchQuery, limit != 0);

                //Execute Query 
                MySqlCommand Command = new MySqlCommand(query, Database.Connection);
                Command.Parameters.AddWithValue("SearchQuery", q);
                Command.Parameters.AddWithValue("Barcode", searchQuery.Barcode);
                Command.Parameters.AddWithValue("Limit", limit);
                MySqlDataReader DataReader = Command.ExecuteReader();

                //Read Data
                while (DataReader.Read())
                {
                    Objects.Product product = new Objects.Product
                    {
                        Id = DataReader["ProductId"].ToString(),
                        Barcode = DataReader["Barcode"].ToString(),
                        Name = DataReader["Name"].ToString(),
                        Description = DataReader["Description"].ToString(),

                        Stock = Func.ToDecimal(DataReader["Stock"].ToString()),
                        SupplyPrice = Func.ToDecimal(DataReader["SupplyPrice"].ToString()),
                        RetailPrice = Func.ToDecimal(DataReader["RetailPrice"].ToString()),
                        Markup = Func.ToDecimal(DataReader["Markup"].ToString()),
                        ImageBlobId = DataReader["ImageBlobId"].ToString(),
                        Color = ColorUtil.HEXToColor(DataReader["Color"].ToString()),

                        IsBalanceRequired = Func.ToBoolean(DataReader["IsBalanceRequired"].ToString()),
                        IsDiscounted = Func.ToBoolean(DataReader["IsDiscounted"].ToString()),

                        UpdatedAt = Convert.ToDateTime(DataReader["UpdatedAt"].ToString()),
                        CreatedAt = Convert.ToDateTime(DataReader["CreatedAt"].ToString()),

                        Discount = new Objects.DiscountProduct
                        {
                            DiscountId = DataReader["DiscountId"].ToString(),
                            ProductId = DataReader["ProductId"].ToString(),
                        },

                        Tax = new Objects.Tax { Id = DataReader["TaxId"].ToString() },
                        Brand = new Objects.ProductBrand { Id = DataReader["BrandId"].ToString() },
                        Supplier = new Objects.ProductSupplier { Id = DataReader["SupplierId"].ToString() },
                        Type = new Objects.ProductType { Id = DataReader["TypeId"].ToString() },

                        IsSearchItem = true,
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
                Logger.QueryError(e, "Product", "Getting Sell Products");
                // Internal Error :
                response.StatusCode = 500;
            }
            //Close Connection if Open
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            return response;
        }

        private string GetInventorySearchQuery(Objects.InventorySearchQuery searchQuery)
        {
            var query = " SELECT * FROM Products ";
            var append = " ORDER BY CreatedAt DESC ";
            var defaultQuery = query + append;

            switch (searchQuery.Type)
            {
                case Enums.SearchQueryType.None:
                    return defaultQuery;

                case Enums.SearchQueryType.Query:
                    return query + " WHERE  (ProductId LIKE  @SearchQuery OR Barcode LIKE  @SearchQuery OR   Name LIKE @SearchQuery OR Description LIKE @SearchQuery )  " + append;

                case Enums.SearchQueryType.Value:
                    // OnStock
                    if (searchQuery.Stock >= ReportConstants.OnStockValue)
                        return query + $" WHERE  ( Stock >= {ReportConstants.OnStockValue} )" + append;
                    // LowStock
                    else if (searchQuery.Stock < ReportConstants.OnStockValue && searchQuery.Stock > ReportConstants.NoStockValue)
                        return query + $" WHERE  ( Stock < {ReportConstants.OnStockValue} AND Stock > {ReportConstants.NoStockValue} )" + append;
                    // NoStock
                    else
                        return query + $" WHERE  ( Stock <= {ReportConstants.NoStockValue} ) " + append;

                case Enums.SearchQueryType.DateRange:
                    return query + " WHERE  CreatedAt BETWEEN @DateFrom AND @DateTo " + append;

                default:
                    return defaultQuery;
            }
        }

        /// <summary>
        /// Get Inventory Products
        /// </summary>
        /// <returns></returns>
        public Response GetInventoryProducts(Objects.InventorySearchQuery searchQuery, Objects.Pagination pagination)
        {
            int statusCode = 200;
            Response response = new Response();
            List<object> products = new List<object>();
            try
            {
                Database.Connection.Open();

                var q = $"%{searchQuery.Query}%";
                var query = GetInventorySearchQuery(searchQuery) + Func.GetPaginationLimit(pagination);

                //Execute Query 
                MySqlCommand Command = new MySqlCommand(query, Database.Connection);
                Command.Parameters.AddWithValue("SearchQuery", q);
                Command.Parameters.AddWithValue("StockQuery", searchQuery.StockQuery);
                Command.Parameters.AddWithValue("DateFrom", searchQuery.DateFrom);
                Command.Parameters.AddWithValue("DateTo", searchQuery.DateTo);
                Command.Parameters.AddWithValue("Status", searchQuery.Status);
                MySqlDataReader DataReader = Command.ExecuteReader();

                //Read Data
                while (DataReader.Read())
                {
                    Objects.Product product = new Objects.Product
                    {
                        Id = DataReader["ProductId"].ToString(),
                        Barcode = DataReader["Barcode"].ToString(),
                        Name = DataReader["Name"].ToString(),
                        Description = DataReader["Description"].ToString(),

                        Stock = Func.ToDecimal(DataReader["Stock"].ToString()),
                        IsBalanceRequired = Func.ToBoolean(DataReader["IsBalanceRequired"].ToString()),
                        SupplyPrice = Func.ToDecimal(DataReader["SupplyPrice"].ToString()),
                        RetailPrice = Func.ToDecimal(DataReader["RetailPrice"].ToString()),
                        Markup = Func.ToDecimal(DataReader["Markup"].ToString()),
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
                    // Nothing
                    statusCode = 204;
                else
                    // OK 
                    statusCode = 200;

                Database.Connection.Close();

                //Response 
                response.StatusCode = statusCode;
                response.DataArray = products;
                response.Pagination = pagination;
            }
            catch (MySqlException e)
            {
                Logger.QueryError(e, "Product", "Getting Products");
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
        public Response Update(Objects.Product product)
        {
            //Props
            int statusCode = 200;
            Response response = new Response();
            var color = ColorUtil.ToHEXColor(product.Color);
            var isBalanceRequired = Func.ToString(product.IsBalanceRequired);
            try
            {
                Database.Connection.Open();

                var query = " UPDATE Products SET ProductId=@ProductId, Barcode=@Barcode, Name=@Name, Description=@Description," +
                                    " Stock=@Stock, IsBalanceRequired=@IsBalanceRequired, SupplyPrice=@SupplyPrice, RetailPrice=@RetailPrice, Markup=@Markup, TaxId=@TaxId, TypeId=@TypeId, " +
                                    " BrandId=@BrandId, SupplierId=@SupplierId, Color=@Color " +
                               " WHERE ProductId=@ProductId ";
                MySqlCommand Command = new MySqlCommand(query, Database.Connection);

                Command.Parameters.AddWithValue("ProductId", product.Id);
                Command.Parameters.AddWithValue("Barcode", product.Barcode);
                Command.Parameters.AddWithValue("Name", product.Name);
                Command.Parameters.AddWithValue("Description", product.Description);
                Command.Parameters.AddWithValue("Stock", product.Stock);
                Command.Parameters.AddWithValue("IsBalanceRequired", isBalanceRequired);
                Command.Parameters.AddWithValue("SupplyPrice", product.SupplyPrice);
                Command.Parameters.AddWithValue("RetailPrice", product.RetailPrice);
                Command.Parameters.AddWithValue("Markup", product.Markup);
                Command.Parameters.AddWithValue("Color", color);

                Command.Parameters.AddWithValue("TaxId", product.Tax.Id);
                Command.Parameters.AddWithValue("TypeId", product.Type.Id);
                Command.Parameters.AddWithValue("BrandId", product.Brand.Id);
                Command.Parameters.AddWithValue("SupplierId", product.Supplier.Id);

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

                Logger.QueryError(e, "Product", "Update");
                // Status Code
                response.StatusCode = statusCode;
            }
            //Close Connection if Open
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            return response;
        }

        /// <summary>
        ///  Update Product Stock
        ///  </summary>
        public Response UpdateStock(Objects.Product product)
        {
            int statusCode = 204;
            Response response = new Response();
            try
            {
                Database.Connection.Open();

                var query = " UPDATE Products SET Stock=@Stock WHERE ProductId=@ProductId ";
                MySqlCommand Command = new MySqlCommand(query, Database.Connection);
                Command.Parameters.AddWithValue("ProductId", product.Id);
                Command.Parameters.AddWithValue("Stock", product.Stock);
                Command.ExecuteNonQuery();

                Database.Connection.Close();

                // Updated Successfully 
                statusCode = 204;
                response.StatusCode = statusCode;
                response.Data = product;
            }
            catch (MySqlException e)
            {
                Logger.QueryError(e, "Product", "Update Stock");
                // Status Code
                response.StatusCode = 500;
            }
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            return response;
        }

        /// <summary>
        /// Updates product's imageBlobId 
        /// </summary>
        public Response UpdateImage(Objects.Product product, Objects.File file)
        {
            Response response = new Response();
            try
            {
                Database.Connection.Open();

                var query = " UPDATE Products SET ImageBlobId=@ImageBlobId WHERE ProductId=@ProductId ";
                MySqlCommand Command = new MySqlCommand(query, Database.Connection);
                Command.Parameters.AddWithValue("ProductId", product.Id);
                Command.Parameters.AddWithValue("ImageBlobId", file.BlobId);
                Command.ExecuteNonQuery();

                Database.Connection.Close();

                // Updated Successfully 
                response.StatusCode = 200;
                response.Data = product;
            }
            catch (MySqlException e)
            {
                Logger.QueryError(e, "Product", "Updating Image");
                // Status Code
                response.StatusCode = 500;
            }
            //Close Connection if Open
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            return response;
        }

        /// <summary>
        ///  Delete 
        /// </summary>
        public Response Delete(Objects.Product product)
        {
            //Props
            int statusCode = 204;
            Response response = new Response();
            try
            {
                Database.Connection.Open();

                string Query = "DELETE FROM Products WHERE ProductId=@ProductId ";
                //Execute Query With Connection  => DataReader
                MySqlCommand Command = new MySqlCommand(Query, Database.Connection);
                Command.Parameters.AddWithValue("ProductId", product.Id);
                Command.ExecuteNonQuery();

                //Close Connection
                Database.Connection.Close();

                //[HTTP Status Code] OK : Successfully Deleted : Returning No Content    
                statusCode = 204;
                response.StatusCode = statusCode;
            }
            catch (MySqlException e)
            {
                Logger.QueryError(e, "Product", "Delete ");
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
