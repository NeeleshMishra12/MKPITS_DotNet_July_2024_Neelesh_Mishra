SELECT c.customer_name, p.product_name
FROM customers c
CROSS JOIN products p
WHERE c.customer_id IN (SELECT DISTINCT customer_id FROM orders);
