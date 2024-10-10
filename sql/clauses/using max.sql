SELECT 
    product_category, 
    MAX(price) AS highest_price
FROM 
    products
GROUP BY 
    product_category;
