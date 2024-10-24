CREATE TRIGGER trg_LogEmployeeDelete
ON Employees
AFTER DELETE
AS
BEGIN
    INSERT INTO EmployeeAudit (EmployeeID, ActionDate, Action)
    SELECT d.EmployeeID, GETDATE(), 'Deleted'
    FROM deleted d;
END;
