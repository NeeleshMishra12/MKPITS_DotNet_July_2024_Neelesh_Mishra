Select C.Id, C.FirstName,C.LastName from Customer C join Orders O on C.ID=O.CustomerId where C.ID!=O.CustomerId
