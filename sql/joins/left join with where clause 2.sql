SELECT 
    orders.order_id,
    orders.order_date,
    orders.customer_id,
    customers.customer_name,
    customers.contact_number,
    customers.address
FROM 
    orders
LEFT JOIN 
    customers ON orders.customer_id = customers.customer_id
WHERE 
    orders.order_date > '2024-01-01';