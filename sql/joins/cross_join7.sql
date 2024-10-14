SELECT o.order_id, p.product_name, c.customer_name
FROM orders o
CROSS JOIN products p
CROSS JOIN customers c
WHERE p.price > 50 AND o.customer_id = c.customer_id;
