--select city from station where city does not start with vowels and dont end with voewls

SELECT DISTINCT(CITY) FROM STATION WHERE LEFT(LOWER(CITY),1) NOT IN('A','E','I','O','U') OR RIGHT(LOWER(CITY),1) NOT IN('A','E','I','O','U')