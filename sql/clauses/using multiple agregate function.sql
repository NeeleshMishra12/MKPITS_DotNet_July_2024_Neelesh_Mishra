SELECT 
    department_id, 
    COUNT(employee_id) AS total_employees, 
    SUM(salary) AS total_salary, 
    AVG(salary) AS average_salary, 
    MAX(salary) AS highest_salary, 
    MIN(salary) AS lowest_salary
FROM 
    employees
GROUP BY 
    department_id;
