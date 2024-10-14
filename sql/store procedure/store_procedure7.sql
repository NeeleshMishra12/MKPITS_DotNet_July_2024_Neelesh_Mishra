CREATE PROCEDURE GetOrderSummary()
BEGIN
    SELECT o.order_id, c.customer_name, o.total_amount, o.order_date
    FROM orders o
    JOIN customers c ON o.customer_id = c.customer_id;
END;
