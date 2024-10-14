CREATE PROCEDURE GetOrdersByCustomer(
    p_customer_id INT
)
BEGIN
    SELECT * FROM orders WHERE customer_id = p_customer_id;
END;
