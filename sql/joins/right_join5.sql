SELECT c.customer_id, SUM(o.amount) AS total_spent
FROM customers c
RIGHT JOIN orders o ON c.customer_id = o.customer_id
GROUP BY c.customer_id;
