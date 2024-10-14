CREATE PROCEDURE DeleteOrder(
    p_order_id INT
)
BEGIN
    DELETE FROM orders WHERE order_id = p_order_id;
END;
