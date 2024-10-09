select c.FirstName,c.Email,Count(OrdersNumber)as totalOrder From Customerdetail c join Orders o ON c.Id=o.CustomerId
group by c.FirstName,c.Email