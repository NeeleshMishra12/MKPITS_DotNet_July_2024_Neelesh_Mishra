SELECT 
    product_category, 
    COUNT(product_id) AS total_products
FROM 
    products
GROUP BY 
    product_category;
