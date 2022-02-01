CREATE PROCEDURE [Обновление клиента]
(@id int,
@fullname nvarchar(100),
@birth_date date,
@phone_number nvarchar(16))
AS
BEGIN
	IF EXISTS(SELECT ID
		FROM Клиент
		WHERE ID = @id)
		BEGIN
			UPDATE Клиент
			SET
				ФИО = @fullname,
				[Дата рождения] = @birth_date,
				Телефон = @phone_number
			WHERE ID = @id
		END
	ELSE
		PRINT(N'Клиента с таким ID не существует!')
END
