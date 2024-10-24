CREATE TRIGGER trg_AuditInsert
ON Employees
AFTER INSERT
AS
BEGIN
    INSERT INTO AuditLog (EmployeeID, Action, ActionDate)
    SELECT i.EmployeeID, 'INSERT', GETDATE()
    FROM inserted i;
END;
