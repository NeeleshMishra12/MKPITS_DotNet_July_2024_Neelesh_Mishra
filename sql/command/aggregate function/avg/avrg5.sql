SELECT MONTH(MeasurementDate) AS Month, AVG(Temperature) AS AverageTemperature
FROM WeatherData
GROUP BY MONTH(MeasurementDate);
