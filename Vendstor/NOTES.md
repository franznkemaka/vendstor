
#/** 
# * Copyright : © RigleSoft™,  Rigle™ - A Company of Franz Nkemaka™ -  All Rights Reserved 
# * Read README for more information. */
✓
// TODO : InProgress
// TODO : Implement Backend
// TODO : Full Clean Up

// TODO : Revision Needed
// TODO : Query Implementation Revision 

// # ->

 if (Translation.IsPossible())
 
else
return;


#Next Release Pull Request : 
- Dynamic, avoid limited Payment Types
- Remove max taxes i.e  more than 2 taxes 


#TODO : 
// MUSTDO : General Don't delete Joined Object if added e.g Don't delete Brand if Brand is linked to something 
// MUSTDO : Translating Remove Variables from string before translating;

#Todo : DashboardForm

- CRUDs Permissons :: User can only see 
- User can see & update Tags, Types, Brands, ... 
- User can only see & create or update : Customer, Groups, ..

- Use callbacks instead of instantiating form 
- OnSizeChanged [Call callback]

- public  Backend.Objects.User User { get; set; } [ in models ] for performances

- Update from double to decimal


- Migrate from dynamic alerts to static alerts


Xxx Created : Xxx Created Successfully
Xxx Deleted : Xxx Deleted Successfully
Xxx Updated : Xxx Updated Successfully

Erorr Creating Xxx : An Error occured while trying to Create Xxx
Erorr Deleting Xxx : An Error occured while trying to Delete Xxx
Erorr Updating Xxx : An Error occured while trying to Update Xxx

Unknown Xxx : The Xxx you're trying to Delete doesn't exist
Unknown Xxx : The Xxx you're trying to Update doesn't exist
Unknown Xxx : The Xxx you're trying to Create doesn't exist
Unknown Xxx : The Xxx you're trying to Get doesn't exist


#SQL
SELECT ProductBrands.*, (SELECT COUNT(*) FROM Products WHERE Products.BrandId = ProductBrands.BrandId ) AS ProductsCount FROM ProductBrands JOIN Products ORDER BY ProductsCount DESC

SELECT ProductBrands.*, 
(SELECT COUNT(*) FROM Products WHERE Products.BrandId = ProductBrands.BrandId ) 
AS ProductsCount FROM ProductBrands 
LEFT OUTER JOIN Products 
ON ( (SELECT COUNT(*) FROM Products) != 0) 
ORDER BY ProductsCount DESC



SELECT Products.*, ProductDiscounts.DiscountId,
       IF(ProductDiscounts.DiscountId IS NULL, FALSE, TRUE) AS IsDiscounted
FROM Products
LEFT JOIN ProductDiscounts ON (Products.ProductId = ProductDiscounts.ProductId)

SELECT DISTINCT Products.*, ProductDiscounts.DiscountId,  
                         IF(ProductDiscounts.DiscountId IS NOT NULL AND ( NOW() BETWEEN (SELECT Discounts.StartDate FROM Discounts WHERE Discounts.DiscountId = ProductDiscounts.DiscountId)   AND  (SELECT Discounts.EndDate FROM Discounts WHERE Discounts.DiscountId = ProductDiscounts.DiscountId)), TRUE, FALSE) AS IsDiscounted FROM Products
                        LEFT JOIN ProductDiscounts
                        ON(Products.ProductId = ProductDiscounts.ProductId)                        
                        LEFT JOIN Discounts
                        ON(Discounts.DiscountId = ProductDiscounts.DiscountId)



SELECT Products.*, ProductSuppliers.*, ProductTypes.*, ProductBrands.* FROM Products LEFT OUTER  JOIN ProductSuppliers, ProductBrands, ProductTypes ON ( ProductSuppliers.SupplierId = Products.SupplierId, ProductTypes.Id = Products.TypeId, ProductBrands.Id = ProductBrands.BrandId )


SELECT ( 
    SELECT SUM(TotalPrice)  FROM Sales WHERE(UserId = 'QEmnHlbZWXTmvBAa8AND' AND SoldAt BETWEEN CURRENT_DATE() AND(NOW() + INTERVAL 1 DAY)) ) AS DailyRevenue, 
    
    ( SELECT SUM(TotalPrice) FROM Sales WHERE (UserId = 'QEmnHlbZWXTmvBAa8AND' AND EXTRACT(WEEK FROM SoldAt) = 43  )) AS WeeklyRevenue,
    
    ( SELECT SUM(TotalPrice)  FROM Sales WHERE(UserId = 'QEmnHlbZWXTmvBAa8AND' AND  EXTRACT(YEAR_MONTH FROM SoldAt) = 201810) ) AS MonthlyRevenue,
    
     ( SELECT SUM(TotalPrice) FROM Sales WHERE(UserId = 'QEmnHlbZWXTmvBAa8AND' AND YEAR(SoldAt) = '2018') ) AS YearlyRevenue,
     
     (  SELECT SUM(TotalPrice) FROM Sales WHERE (UserId = 'QEmnHlbZWXTmvBAa8AND' ) ) AS TotalRevenue


# Total Products
# SELECT COUNT(*) As TotalProducts FROM Products


# Total Customers
# SELECT COUNT(*) As TotalCustomers FROM Customers

# Weekly Sales
# SELECT COUNT(*) FROM Sales WHERE (EXTRACT(WEEK FROM SoldAt) = @WeekNumOfYear )) AS WeeklySales

# Total Revenue
# SELECT COUNT(TotalPrice) As TotalRevenue FROM Sales

# Top Sold Products By Quantity 
# SELECT SUM(Quantity) As TotalQuantity, ProductId   FROM SaleItems GROUP BY ProductId ORDER BY TotalQuantity DESC


# Daily Revenue
# SELECT SUM(TotalPrice) As Amount, SoldAt FROM Sales GROUP BY DATE(SoldAt)

# Daily Revenue (Last 7 Days + Now)
#SELECT SUM(TotalPrice) As Amount, SoldAt  FROM Sales WHERE SoldAt BETWEEN   NOW() + INTERVAL -7 DAY AND  NOW() GROUP BY DATE(SoldAt)

