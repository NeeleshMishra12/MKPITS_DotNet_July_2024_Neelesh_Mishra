SELECT 
    employee_id,
    first_name,
    last_name,
    department_id,
    salary,
    hire_date
FROM 
    employees
ORDER BY 
    department_id ASC, 
    salary DESC, 
    hire_date ASC, 
    last_name ASC, 
    first_name ASC;
