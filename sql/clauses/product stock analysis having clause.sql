SELECT 
    supplier_id,
    product_category,
    warehouse_id,
    SUM(stock_quantity) AS total_stock,
    MIN(price) AS min_price,
    MAX(price) AS max_price
FROM 
    products
GROUP BY 
    supplier_id, product_category, warehouse_id
HAVING 
    SUM(stock_quantity) > 1000 
    AND MIN(price) < 10 
    AND MAX(price) > 100;
