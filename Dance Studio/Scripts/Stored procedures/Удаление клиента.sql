CREATE PROCEDURE [�������� �������]
(@client_FIO nvarchar(100),
@phone nvarchar(100),
@Message nvarchar(100) OUTPUT)
AS
BEGIN
	DECLARE @id int
	SELECT @id = ID
		FROM ������
		WHERE ��� = @client_FIO AND ������� = @phone
	IF @id IS NOT NUlL
		BEGIN
			IF NOT EXISTS (SELECT ������
				FROM ���������
				WHERE ������ = @id)
				BEGIN
					DELETE FROM ������
						WHERE ID = @id
				END
			ELSE
				BEGIN
					PRINT(N'���������� ������� �������, �������� ���������!')
					SET @Message = N'���������� ������� �������, �������� ���������!';
				END
		END
	ELSE
		BEGIN
			PRINT(N'������� �� ����������!')
			SET @Message = N'������� �� ����������!';
		END
END