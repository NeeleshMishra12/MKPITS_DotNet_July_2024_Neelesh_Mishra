--query the list of city names end with vowels from station


select city from Station where 
city Like '%A'
or
city Like '%E'
or
city Like '%I'
or
city Like '%O'
or
city Like '%U';