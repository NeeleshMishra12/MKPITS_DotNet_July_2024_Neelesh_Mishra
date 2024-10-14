SELECT p.product_name, s.supplier_name, s.contact
FROM products p
CROSS JOIN suppliers s
WHERE s.contact IS NOT NULL;
