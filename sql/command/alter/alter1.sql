ALTER TABLE Customers
DROP COLUMN OldEmailAddress;
ALTER TABLE Customers
ADD NewEmailAddress VARCHAR(100) NOT NULL;
