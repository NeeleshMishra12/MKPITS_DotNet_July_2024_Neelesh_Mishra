SELECT 
    employees.employee_id,
    employees.first_name,
    employees.last_name,
    employees.department_id,
    departments.department_name,
    departments.location_id
FROM 
    employees
LEFT JOIN 
    departments ON employees.department_id = departments.department_id
WHERE 
    employees.status = 'Active';
