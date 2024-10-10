SELECT 
    customer_id,
    year(order_date) AS order_year,
    product_category,
    COUNT(order_id) AS order_count,
    SUM(order_amount) AS total_amount,
    AVG(order_amount) AS avg_order_value
FROM 
    orders
GROUP BY 
    customer_id, year(order_date), product_category
HAVING 
    COUNT(order_id) >= 5 
    AND SUM(order_amount) >= 10000 
    AND AVG(order_amount) > 500;
