CREATE TRIGGER [Вставка записей на сеанc татуировки]
ON [Запись на сеанс татуировки]
INSTEAD OF INSERT
AS
DECLARE @master int
DECLARE @client int
DECLARE @sketch int
DECLARE @work_type int
DECLARE @date date
DECLARE @time time
DECLARE Record_cursor CURSOR LOCAL
FOR 
	SELECT Мастер, Клиент, Эскиз, [Вид работы], Дата, Время
		FROM inserted
	OPEN Record_cursor
	FETCH NEXT FROM Record_cursor INTO @master, @client, @sketch, @work_type, @date, @time
	WHILE @@FETCH_STATUS = 0
		BEGIN
			DECLARE @work_time int
			DECLARE @price money
			EXEC [Расчёт времени сеанса] @work_type, @sketch, @work_time OUTPUT
			EXEC [Расчёт стоимости сеанса] @master, @work_type, @sketch, @price OUTPUT
			INSERT INTO [Запись на сеанс татуировки]
			VALUES
				(@master, @client, @sketch, @work_type, @date, @time, @work_time, @price)
			FETCH NEXT FROM Record_cursor INTO @master, @client, @sketch, @work_type, @date, @time
		END
	CLOSE Record_cursor
DEALLOCATE Record_cursor
GO
