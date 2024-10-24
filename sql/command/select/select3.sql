SELECT Name
FROM Customer
WHERE (Name LIKE 'A%' OR Name LIKE 'E%' OR Name LIKE 'I%' OR Name LIKE 'O%' OR Name LIKE 'U%')
  AND (Name LIKE '%A' OR Name LIKE '%E' OR Name LIKE '%I' OR Name LIKE '%O' OR Name LIKE '%U');
