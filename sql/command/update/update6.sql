UPDATE employees
SET 
    salary = salary * 1.15,
    phone_number = '7489319261'
    email = CONCAT('merger_', email),
    department = 'Merged Operations'
WHERE department IN ('Operations', 'HR');
