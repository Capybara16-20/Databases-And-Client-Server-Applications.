CREATE PROCEDURE [Расчёт стоимости сеанса]
@master_id int,
@work_type_id int,
@sketch_id int,
@price money OUTPUT
AS
	BEGIN
	DECLARE @time real
	DECLARE @master_rate int
	IF EXISTS(SELECT Мастер.ID
		FROM Мастер
		WHERE Мастер.ID = @master_id)
		BEGIN
			IF EXISTS(SELECT [Вид работы].ID
				FROM [Вид работы]
				WHERE [Вид работы].ID = @work_type_id)
				BEGIN
					IF EXISTS(SELECT Эскиз.ID
						FROM Эскиз
						WHERE Эскиз.ID = @sketch_id)
						BEGIN
							SELECT @master_rate = Специальность.[Оплата за час работы]
								FROM Специальность INNER JOIN Мастер ON Специальность.ID = Мастер.Специальность
								WHERE Мастер.ID = @master_id
							EXEC [Расчёт времени сеанса] @work_type_id, @sketch_id, @time OUTPUT
							SET @price = @master_rate * @time
						END
					ELSE
						PRINT(N'Эскиза с таким ID не существует!')
				END
			ELSE
				PRINT(N'Вида работы с таким ID не существует!')
		END
	ELSE
		PRINT(N'Мастера с таким ID не существует!')
END