SELECT 
    job_title, 
    AVG(salary) AS average_salary
FROM 
    employees
GROUP BY 
    job_title;
