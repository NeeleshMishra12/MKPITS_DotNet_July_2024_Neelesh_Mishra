SELECT YEAR(OrderDate) AS Year, SUM(TotalAmount) AS TotalRevenue
FROM Orders
GROUP BY YEAR(OrderDate)
ORDER BY Year;
