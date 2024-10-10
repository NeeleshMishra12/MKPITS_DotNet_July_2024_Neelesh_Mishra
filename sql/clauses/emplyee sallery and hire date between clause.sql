SELECT 
    employee_id,
    first_name,
    last_name,
    department_id,
    salary,
    hire_date
FROM 
    employees
WHERE 
    salary BETWEEN 50000 AND 100000
    AND hire_date BETWEEN '2020-01-01' AND '2023-12-31'
    AND department_id BETWEEN 10 AND 50
    AND employee_id BETWEEN 1000 AND 2000;
