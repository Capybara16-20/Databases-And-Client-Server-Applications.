CREATE PROCEDURE [Расчёт времени нанесения эскиза]
@style_id int,
@size_id int,
@time real OUTPUT
AS
BEGIN
	DECLARE @basetime real
	DECLARE @style_coef real
	DECLARE @size_coef real
	IF EXISTS(SELECT Стиль.ID
		FROM Стиль
		WHERE Стиль.ID = @style_id)
		BEGIN
			IF EXISTS(SELECT Размер.ID
				FROM Размер
				WHERE Размер.ID = @size_id)
				BEGIN
					SELECT @basetime = [Вид работы].[Начальное время]
						FROM [Вид работы]
						WHERE [Вид работы].ID = 1
					SELECT @size_coef = Размер.[Коэффициент времени]
						FROM Размер
						WHERE Размер.ID = @size_id
					SELECT @style_coef = Стиль.[Коэффициент времени]
						FROM Стиль
						WHERE Стиль.ID = @style_id
					SET @time = @basetime * @size_coef * @style_coef
				END
			ELSE
				PRINT(N'Размера с таким ID не существует!')
		END
	ELSE
		PRINT(N'Стиля с таким ID не существует!')
END