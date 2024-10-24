CREATE TRIGGER trg_LogEmployeeUpdate
ON Employees
AFTER UPDATE
AS
BEGIN
    INSERT INTO EmployeeAudit (EmployeeID, ActionDate, Action)
    SELECT i.EmployeeID, GETDATE(), 'Updated'
    FROM inserted i;
END;
