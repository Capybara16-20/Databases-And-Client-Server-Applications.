CREATE PROCEDURE [Обновление записи на услугу]
@record_id int,
@master_id int,
@client_id int,
@service_type_id int,
@date date,
@time time
AS
BEGIN
	DECLARE @price money
	SELECT @price = Стоимость
	FROM [Вид услуги]
	WHERE ID = @service_type_id
	IF EXISTS(SELECT [Запись на услугу].ID
		FROM [Запись на услугу]
		WHERE [Запись на услугу].ID = @record_id)
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
											UPDATE [Запись на услугу]
												SET
													Мастер = @master_id,
													Клиент = @client_id,
													[Вид услуги] = @service_type_id,
													Дата = @date,
													Время = @time,
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
		PRINT(N'Записи на сеанс с таким ID не существует!')
END