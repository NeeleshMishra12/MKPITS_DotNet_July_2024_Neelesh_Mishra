SELECT 
    region, 
    MIN(sales_amount) AS smallest_sale
FROM 
    sales
GROUP BY 
    region;
