select o.OrdersDate,o.CustomerId,o.TotalAmount,o.OrdersNumber
from Orders o join  Customerdetail c on o.CustomerId = c.Id; 