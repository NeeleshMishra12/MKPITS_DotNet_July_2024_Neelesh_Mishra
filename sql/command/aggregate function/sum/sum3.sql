SELECT CustomerID, SUM(Quantity) AS TotalQuantity
FROM OrderDetails
GROUP BY CustomerID;