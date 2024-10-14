CREATE PROCEDURE AddProduct(
    p_product_name VARCHAR(255),
    p_price DECIMAL(10, 2),
    p_stock INT
)
BEGIN
    INSERT INTO products (product_name, price, stock) 
    VALUES (p_product_name, p_price, p_stock);
END;
