--select city from station not start with vowel. 

select Distinct city from station 
where  city  not Like 'a%'
and city  not Like 'e%'
 and city  not Like 'i%'
 and city  not Like 'o%'
 and city  not Like 'u%';