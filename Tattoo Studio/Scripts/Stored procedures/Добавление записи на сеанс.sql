CREATE PROCEDURE [Добавление записи на сеанс]
@master_id int,
@client_id int,
@sketch_id int,
@work_type_id int,
@date date,
@time time
AS
BEGIN
	DECLARE @work_time real
	DECLARE @price money
	EXEC [Расчёт времени сеанса] @work_type_id, @sketch_id, @work_time OUTPUT
	EXEC [Расчёт стоимости сеанса] @master_id, @work_type_id, @sketch_id, @price OUTPUT
	INSERT INTO [Запись на сеанс татуировки]
	VALUES
		(@master_id, @client_id, @sketch_id, @work_type_id, @date, @time, @work_time, @price)
END