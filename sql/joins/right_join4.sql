SELECT c.customer_name, COUNT(o.order_id) AS total_orders
FROM customers c
RIGHT JOIN orders o ON c.customer_id = o.customer_id
GROUP BY c.customer_name;
