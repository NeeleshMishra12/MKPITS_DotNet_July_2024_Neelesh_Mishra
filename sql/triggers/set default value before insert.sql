CREATE TRIGGER trg_DefaultStatus
ON Orders
BEFORE INSERT
AS
BEGIN
    UPDATE inserted
    SET Status = 'Pending'
    WHERE Status IS NULL;
END;
