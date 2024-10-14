ALTER TABLE Employees
ADD 
    MiddleName VARCHAR(50) NULL,
    BirthDate DATE NULL,
    IsActive BIT DEFAULT 1;
