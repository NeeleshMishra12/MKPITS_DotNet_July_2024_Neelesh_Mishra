SELECT CategoryID, AVG(Price) AS AveragePrice
FROM Products
GROUP BY CategoryID
ORDER BY AveragePrice DESC;
