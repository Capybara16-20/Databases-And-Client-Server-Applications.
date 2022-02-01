CREATE PROCEDURE [Расчёт времени сеанса]
@work_type_id int,
@sketch_id int,
@time real OUTPUT
AS
	BEGIN
	DECLARE @basetime real
	DECLARE @size_coef real
	DECLARE @style_coef real
	IF EXISTS(SELECT [Вид работы].[Начальное время]
		FROM [Вид работы]
		WHERE [Вид работы].ID = @work_type_id)
		BEGIN
			IF EXISTS(SELECT Эскиз.ID
				FROM Эскиз
				WHERE Эскиз.ID = @sketch_id)
				BEGIN
					SELECT @basetime = [Вид работы].[Начальное время]
						FROM [Вид работы]
						WHERE [Вид работы].ID = @work_type_id
					SELECT @size_coef = Размер.[Коэффициент времени]
						FROM Эскиз INNER JOIN Размер ON Эскиз.Размер = Размер.ID
						WHERE Эскиз.ID = @sketch_id
					SELECT @style_coef = Стиль.[Коэффициент времени]
						FROM Эскиз INNER JOIN Стиль ON Эскиз.Стиль = Стиль.ID
						WHERE Эскиз.ID = @sketch_id
					SET @time = @basetime * @size_coef * @style_coef
				END
			ELSE
				PRINT(N'Эскиза с таким ID не существует!')
		END
	ELSE
		PRINT(N'Вида работы с таким ID не существует!')
END