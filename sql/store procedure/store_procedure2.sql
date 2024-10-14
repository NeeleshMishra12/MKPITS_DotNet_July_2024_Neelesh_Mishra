CREATE PROCEDURE GetCustomerByID(
    p_customer_id INT
)
BEGIN
    SELECT * FROM customers WHERE customer_id = p_customer_id;
END;
