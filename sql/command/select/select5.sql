--select city from station where city does not end with vowels...

SELECT  DISTINCT  CITY  FROM STATION
WHERE city not LIKE '%A'
AND  city  not LIKE '%E'
AND  city  not LIKE '%I'
AND  city  not LIKE '%O'
AND  city   not LIKE '%U';


