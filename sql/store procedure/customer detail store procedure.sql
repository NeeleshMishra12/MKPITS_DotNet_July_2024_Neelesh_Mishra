create  procedure details
@FirstName varchar(50),
@LastName varchar(50),
@City varchar(50),
@Country varchar(50),
@Phone varchar(50),
@Email varchar(25),
@countryname varchar(50),
@regionid varchar(50)
as
begin
insert into Customerdetail(FirstName,LastName,City,Country,Phone,Email) values(@FirstName,@LastName,@City,@Country,@Phone,@Email)
insert into countries(countryname,regionid) values(@countryname,@regionid)
end
exec details @FirstName='Neelesh',@LastName='Mishra',@City='Nagpur',@Country='India',@Phone='987654',@Email='mishr@2002',@countryname='India',@regionid='259285';