SELECT Region, AVG(SalesAmount) AS AverageSales
FROM Sales
GROUP BY Region
ORDER BY AverageSales DESC;
