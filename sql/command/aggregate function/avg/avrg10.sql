SELECT YEAR(InvoiceDate) AS Year, AVG(TotalAmount) AS AverageInvoiceAmount
FROM Invoices
GROUP BY YEAR(InvoiceDate);
