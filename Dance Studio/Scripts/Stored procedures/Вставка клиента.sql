CREATE PROCEDURE [������� �������]
(@fullname nvarchar(100),
@birth_date date,
@phone_number nvarchar(16))
AS
BEGIN
INSERT INTO ������
VALUES
 (@fullname, @birth_date, @phone_number)
END
