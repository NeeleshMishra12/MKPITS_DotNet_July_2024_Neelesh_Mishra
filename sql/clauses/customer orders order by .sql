SELECT 
    order_id,
    customer_id,
    order_date,
    product_id,
    quantity,
    total_price,
    shipping_date
FROM 
    orders
ORDER BY 
    customer_id ASC, 
    order_date DESC, 
    total_price DESC, 
    shipping_date ASC, 
    quantity ASC;
