UPDATE employees
SET 
    salary = salary + 5000,
    status = 'reviewed',
    department = 'Management',
    hire_date = DATEADD(year, 1, hire_date)
WHERE salary < 50000 AND status = 'active';
