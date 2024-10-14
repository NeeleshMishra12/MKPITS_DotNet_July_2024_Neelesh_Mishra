SELECT p.product_name, s.supplier_name
FROM products p
CROSS JOIN suppliers s
WHERE p.category = 'Electronics';
