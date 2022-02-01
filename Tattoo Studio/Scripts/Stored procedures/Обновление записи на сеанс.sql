CREATE PROCEDURE [Обновление записи на сеанс]
@record_id int,
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
	IF EXISTS(SELECT [Запись на сеанс татуировки].ID
		FROM [Запись на сеанс татуировки]
		WHERE [Запись на сеанс татуировки].ID = @record_id)
		BEGIN
			IF EXISTS(SELECT Мастер.ID
				FROM Мастер
				WHERE Мастер.ID = @master_id)
				BEGIN
					IF EXISTS(SELECT Клиент.ID
						FROM Клиент
						WHERE Клиент.ID = @client_id)
						BEGIN
							IF EXISTS(SELECT Клиент.ID
								FROM Клиент
								WHERE Клиент.ID = @client_id)
								BEGIN
									IF EXISTS(SELECT Клиент.ID
										FROM Клиент
										WHERE Клиент.ID = @client_id)
										BEGIN
											EXEC [Расчёт времени сеанса] @work_type_id, @sketch_id, @work_time OUTPUT
											EXEC [Расчёт стоимости сеанса] @master_id, @work_type_id, @sketch_id, @price OUTPUT
											UPDATE [Запись на сеанс татуировки]
												SET
													Мастер = @master_id,
													Клиент = @client_id,
													Эскиз = @sketch_id,
													[Вид работы] = @work_type_id,
													Дата = @date,
													Время = @time,
													[Время работы] = @work_time,
													Цена = @price
												WHERE ID = @record_id
										END
									ELSE
										PRINT(N'Вида работы с таким ID не существует!')
								END
							ELSE
								PRINT(N'Эскиза с таким ID не существует!')
						END
					ELSE
						PRINT(N'Клиента с таким ID не существует!')
				END
			ELSE
				PRINT(N'Мастера с таким ID не существует!')
		END
	ELSE
		PRINT(N'Записи на услугу с таким ID не существует!')
END