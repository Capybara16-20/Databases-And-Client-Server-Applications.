CREATE PROCEDURE [Обновление эскиза]
@sketch_id int,
@style_id int,
@size_id int
AS
BEGIN
	DECLARE @time real
	IF EXISTS(SELECT Эскиз.ID
		FROM Эскиз
		WHERE Эскиз.ID = @sketch_id)
		BEGIN
			EXEC [Расчёт времени сеанса] @style_id, @size_id, @time OUTPUT
			UPDATE Эскиз
			SET
			Стиль = @style_id,
			Размер = @size_id,
			[Время нанесения] = @time
			WHERE ID = @sketch_id
		END
	ELSE
		PRINT(N'Эскиза с таким ID не существует!')
END