SELECT 
    store_id,
    product_type,
    quarter(sale_date) AS sale_quarter,
    SUM(revenue) AS total_revenue,
    COUNT(product_id) AS product_count,
    AVG(revenue) AS average_revenue_per_product
FROM 
    sales
GROUP BY 
    store_id, product_type, quarter(sale_date)
HAVING 
    SUM(revenue) > 100000 
    AND COUNT(product_id) > 50 
    AND AVG(revenue) > 2000;
