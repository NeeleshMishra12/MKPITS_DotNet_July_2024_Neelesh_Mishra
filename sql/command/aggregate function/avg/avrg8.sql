SELECT CustomerID, AVG(CallDuration) AS AverageCallDuration
FROM CallRecords
GROUP BY CustomerID;
