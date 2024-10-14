CREATE PROCEDURE UpdateProductStock(
    p_product_id INT,
    p_stock INT
)
BEGIN
    UPDATE products
    SET stock = p_stock
    WHERE product_id = p_product_id;
END;
