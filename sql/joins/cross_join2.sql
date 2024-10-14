SELECT c.customer_name, c.city, p.product_name
FROM customers c
CROSS JOIN products p
WHERE c.city = 'New York';
