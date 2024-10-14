SELECT CustomerID, AVG(TotalAmount) AS AverageOrderValue
FROM Orders
GROUP BY CustomerID;
