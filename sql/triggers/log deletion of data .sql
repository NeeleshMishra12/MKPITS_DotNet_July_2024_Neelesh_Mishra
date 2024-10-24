CREATE TRIGGER trg_LogDelete
ON Employees
AFTER DELETE
AS
BEGIN
    INSERT INTO EmployeeAudit (EmployeeID, Action, ActionDate)
    SELECT d.EmployeeID, 'DELETE', GETDATE()
    FROM deleted d;
END;
