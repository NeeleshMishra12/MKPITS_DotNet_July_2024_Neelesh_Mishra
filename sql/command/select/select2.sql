--select name starting with vowels

select name from Customers 
where city LIKE 'A%'
 or where city LIKE 'E%'
 or where city LIKE 'I%'
 or where city LIKE 'O%'
 or where city LIKE 'U%';