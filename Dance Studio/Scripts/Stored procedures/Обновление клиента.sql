CREATE PROCEDURE [���������� �������]
(@id int,
@fullname nvarchar(100),
@birth_date date,
@phone_number nvarchar(16))
AS
BEGIN
	IF EXISTS(SELECT ID
		FROM ������
		WHERE ID = @id)
		BEGIN
			UPDATE ������
			SET
				��� = @fullname,
				[���� ��������] = @birth_date,
				������� = @phone_number
			WHERE ID = @id
		END
	ELSE
		PRINT(N'������� � ����� ID �� ����������!')
END
