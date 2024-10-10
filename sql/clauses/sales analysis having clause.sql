SELECT 
    region,
    product_category,
    sales_rep,
    SUM(sales_amount) AS total_sales,
    COUNT(order_id) AS total_orders,
    AVG(sales_amount) AS average_sale
FROM 
    sales
GROUP BY 
    region, product_category, sales_rep
HAVING 
    SUM(sales_amount) > 50000 
    AND COUNT(order_id) > 20 
    AND AVG(sales_amount) > 2000;
