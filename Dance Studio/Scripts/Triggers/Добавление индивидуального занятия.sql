CREATE TRIGGER [Добавление индивидуального занятия]
ON [Индивидуальное занятие]
INSTEAD OF INSERT
AS
DECLARE @membership int
DECLARE @teacher int
DECLARE @date date
DECLARE @time time
SELECT @membership = Абонемент, @teacher = Преподаватель, @date = Дата, @time = Время
	FROM inserted
DECLARE @client int
SELECT @client = Клиент
	FROM Абонемент
	WHERE ID = @membership
DECLARE @temp_date datetime = CAST(@time AS datetime)
DECLARE @old_date datetime
SET @old_date = DATEADD(HOUR, -1, @temp_date)
DECLARE @new_date datetime
SET @new_date = DATEADD(HOUR, 1, @temp_date)
DECLARE @old_time time
SELECT @old_time = CAST(@old_date AS time)
DECLARE @new_time time
SELECT @new_time = CAST(@new_date AS time)
IF NOT EXISTS(SELECT Занятие.ID
	FROM (Занятие JOIN Группа ON Занятие.Группа = Группа.ID)
		JOIN [Абонементы групп] ON Группа.ID = [Абонементы групп].Группа
	WHERE Дата = @date AND Время >= @old_time AND Время < @new_time AND Преподаватель = @teacher)
BEGIN
	IF NOT EXISTS(SELECT Занятие.ID
		FROM (Занятие JOIN Группа ON Занятие.Группа = Группа.ID)
			JOIN [Абонементы групп] ON Группа.ID = [Абонементы групп].Группа
		WHERE Дата = @date AND Время >= @old_time AND Время < @new_time AND Абонемент = @membership)
	BEGIN
		IF NOT EXISTS(SELECT [Индивидуальное занятие].ID
			FROM [Индивидуальное занятие]
			WHERE Дата = @date AND Время >= @old_time AND Время < @new_time AND Преподаватель = @teacher)
		BEGIN
			IF NOT EXISTS(SELECT [Индивидуальное занятие].ID
				FROM [Индивидуальное занятие]
				WHERE Дата = @date AND Время >= @old_time AND Время < @new_time AND Абонемент = @membership)
			BEGIN
				INSERT INTO [Индивидуальное занятие]
				VALUES
					(@membership, @teacher, @date, @time)
			END
			ELSE
				PRINT(N'Клиент записан на индивидуальное занятие в это время!')
		END
		ELSE
			PRINT(N'Преподаватель проводит индивидуальное занятие в это время!')
	END
	ELSE
		PRINT(N'Клиент записан на групповое занятие в это время!')
END
ELSE
	PRINT(N'Преподаватель проводит групповое занятие в это время!')
GO