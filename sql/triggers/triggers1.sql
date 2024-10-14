CREATE TRIGGER notify_customer_after_order_insert
AFTER INSERT ON orders
FOR EACH ROW
BEGIN
    INSERT INTO customer_notifications (customer_id, message, notification_date)
    VALUES (NEW.customer_id, CONCAT('Order ', NEW.order_id, ' has been placed.'), NOW());
END;
