CREATE PROCEDURE UpdateCustomerName(
    p_customer_id INT,
    p_new_name VARCHAR(255)
)
BEGIN
    UPDATE customers
    SET customer_name = p_new_name
    WHERE customer_id = p_customer_id;
END;
