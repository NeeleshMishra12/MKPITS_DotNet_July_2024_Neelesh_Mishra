CREATE PROCEDURE GetProductDetails(
    p_product_id INT
)
BEGIN
    SELECT product_name, price, stock 
    FROM products 
    WHERE product_id = p_product_id;
END;
