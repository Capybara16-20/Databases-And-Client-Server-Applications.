CREATE PROCEDURE [Удаление клиента]
(@client_FIO nvarchar(100),
@phone nvarchar(100),
@Message nvarchar(100) OUTPUT)
AS
BEGIN
	DECLARE @id int
	SELECT @id = ID
		FROM Клиент
		WHERE ФИО = @client_FIO AND Телефон = @phone
	IF @id IS NOT NUlL
		BEGIN
			IF NOT EXISTS (SELECT Клиент
				FROM Абонемент
				WHERE Клиент = @id)
				BEGIN
					DELETE FROM Клиент
						WHERE ID = @id
				END
			ELSE
				BEGIN
					PRINT(N'Невозможно удалить клиента, имеющего абонемент!')
					SET @Message = N'Невозможно удалить клиента, имеющего абонемент!';
				END
		END
	ELSE
		BEGIN
			PRINT(N'Клиента не существует!')
			SET @Message = N'Клиента не существует!';
		END
END