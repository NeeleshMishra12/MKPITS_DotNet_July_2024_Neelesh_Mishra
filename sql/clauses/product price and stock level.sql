SELECT 
    product_id,
    product_name,
    category_id,
    supplier_id,
    price,
    stock_quantity,
    last_restocked
FROM 
    products
WHERE 
    price BETWEEN 20 AND 100
    AND stock_quantity BETWEEN 50 AND 500
    AND category_id BETWEEN 1 AND 5
    AND last_restocked BETWEEN '2024-01-01' AND '2024-12-31';
