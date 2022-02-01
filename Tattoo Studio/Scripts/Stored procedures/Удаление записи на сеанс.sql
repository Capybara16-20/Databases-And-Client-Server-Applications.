CREATE PROCEDURE [Удаление записи на сеанс]
@record_id int
AS
BEGIN
	IF EXISTS(SELECT [Запись на сеанс татуировки].ID
		FROM [Запись на сеанс татуировки]
		WHERE [Запись на сеанс татуировки].ID = @record_id)
		BEGIN
			DELETE FROM [Запись на сеанс татуировки]
			WHERE [Запись на сеанс татуировки].ID = @record_id
		END
	ELSE
		PRINT(N'Записи на сеанс с таким ID не существует!')
END