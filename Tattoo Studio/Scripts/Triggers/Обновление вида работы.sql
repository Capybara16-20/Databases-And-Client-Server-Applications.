CREATE TRIGGER [Обновление вида работы]
ON [Вид работы]
AFTER UPDATE
AS
DECLARE @work_type int
DECLARE @name nvarchar(100)
DECLARE @basic_time real

DECLARE Work_type_cursor CURSOR LOCAL
FOR 
	SELECT ID, Название, [Начальное время]
		FROM inserted
	OPEN Work_type_cursor
	FETCH NEXT FROM Work_type_cursor INTO @work_type, @name, @basic_time
	WHILE @@FETCH_STATUS = 0
		BEGIN
			UPDATE [Вид работы]
			SET 
				Название = @name,
				[Начальное время] = @basic_time
				WHERE ID = @work_type
			DECLARE @record int
			DECLARE @master int
			DECLARE @sketch int
			DECLARE Record_cursor CURSOR
			FOR
				SELECT Мастер, Эскиз
					FROM [Запись на сеанс татуировки]
				OPEN Record_cursor
				FETCH NEXT FROM Record_cursor INTO @master, @sketch
				WHILE @@FETCH_STATUS = 0
					BEGIN
						DECLARE @work_time int
						DECLARE @price money
						EXEC [Расчёт времени сеанса] @work_type, @sketch, @work_time OUTPUT
						EXEC [Расчёт стоимости сеанса] @master, @work_type, @sketch, @price OUTPUT
						UPDATE [Запись на сеанс татуировки]
						SET
							[Время работы] = @work_time,
							Цена = @price
							WHERE [Вид работы] = @work_type AND Мастер = @master AND Эскиз = @sketch

						FETCH NEXT FROM Record_cursor INTO @master, @sketch
					END
				CLOSE Record_cursor
			DEALLOCATE Record_cursor
			FETCH NEXT FROM Work_type_cursor INTO @work_type, @name, @basic_time
			END
	CLOSE Work_type_cursor
DEALLOCATE Work_type_cursor
GO
