SELECT 
    sales_rep_id,
    region,
    total_sales,
    target_achieved,
    bonus_amount,
    commission_rate,
    performance_score
FROM 
    sales_reps
WHERE 
    total_sales BETWEEN 100000 AND 500000
    AND target_achieved BETWEEN 80 AND 100
    AND bonus_amount BETWEEN 5000 AND 20000
    AND commission_rate BETWEEN 5 AND 15
    AND performance_score BETWEEN 70 AND 100;
