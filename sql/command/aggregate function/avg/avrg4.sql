SELECT AVG(Salary) AS AverageSalaryLastYear
FROM Employees
WHERE HireDate >= DATEADD(YEAR, -1, GETDATE());
