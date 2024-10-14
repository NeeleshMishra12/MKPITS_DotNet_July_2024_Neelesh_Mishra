SELECT p.product_name, s.supplier_name, p.price
FROM products p
CROSS JOIN suppliers s
WHERE p.price > 100;
