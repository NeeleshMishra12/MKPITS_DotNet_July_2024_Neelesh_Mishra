SELECT EmployeeID, SUM(HoursWorked) AS TotalHours
FROM TimeEntries
GROUP BY EmployeeID
HAVING SUM(HoursWorked) > 40;  -- Only employees with more than 40 hours
