SELECT c.customer_name, o.order_id, o.amount
FROM orders o
RIGHT JOIN customers c ON o.customer_id = c.customer_id;
