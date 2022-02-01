CREATE PROCEDURE [Добавление эскиза]
@style_id int,
@size_id int
AS
BEGIN
	DECLARE @time real
	EXEC [Расчёт времени нанесения эскиза] @style_id, @size_id, @time OUTPUT
	INSERT INTO Эскиз
	VALUES
		(@style_id, @size_id, @time)
END