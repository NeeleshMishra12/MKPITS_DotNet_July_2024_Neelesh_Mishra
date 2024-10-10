SELECT 
    department_id,
    job_title,
    manager_id,
    COUNT(employee_id) AS total_employees,
    SUM(salary) AS total_salary,
    AVG(salary) AS avg_salary
FROM 
    employees
GROUP BY 
    department_id, job_title, manager_id
HAVING 
    COUNT(employee_id) > 10 
    AND SUM(salary) > 300000 
    AND AVG(salary) < 50000;
