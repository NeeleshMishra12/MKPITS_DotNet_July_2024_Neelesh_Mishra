SELECT DepartmentID, SUM(Expenditure) AS TotalExpenditure
FROM Budget
GROUP BY DepartmentID;
