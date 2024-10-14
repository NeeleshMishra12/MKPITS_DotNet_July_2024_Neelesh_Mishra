SELECT Gender, AVG(DATEDIFF(YEAR, BirthDate, GETDATE())) AS AverageAge
FROM Customers
GROUP BY Gender;
