SELECT 
    products.product_id,
    products.product_name,
    products.category_id,
    products.price,
    categories.category_name,
    categories.description
FROM 
    products
LEFT JOIN 
    categories ON products.category_id = categories.category_id
WHERE 
    products.price > 100;
