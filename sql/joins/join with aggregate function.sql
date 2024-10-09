select c.Id,c.FirstName,c.LastName,c.Email,COUNT(OrdersNumber) As totalOrders 
From Customerdetail c join Orders o ON c.Id=o.CustomerId
group by c.Id,c.FirstName,c.LastName,c.Email;