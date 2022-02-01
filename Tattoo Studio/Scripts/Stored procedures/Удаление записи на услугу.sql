CREATE PROCEDURE [Удаление записи на услугу]
@record_id int
AS
BEGIN
	IF EXISTS(SELECT [Запись на услугу].ID
		FROM [Запись на услугу]
		WHERE [Запись на услугу].ID = @record_id)
		BEGIN
			DELETE FROM [Запись на услугу]
			WHERE [Запись на услугу].ID = @record_id
		END
	ELSE
		PRINT(N'Записи на услугу с таким ID не существует!')
END