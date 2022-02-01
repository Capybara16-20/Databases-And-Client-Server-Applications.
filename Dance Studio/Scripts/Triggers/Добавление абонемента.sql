CREATE TRIGGER [Добавление абонемента]
ON Абонемент
INSTEAD OF INSERT
AS
DECLARE @client int
DECLARE @membership_type int
DECLARE @individual_lessons_count int
SELECT @client = Клиент, @membership_type = [Вид абонемента], @individual_lessons_count = [Количество индивидуальных занятий]
	FROM inserted
DECLARE @price real
EXEC [Cтоимость абонемента] @membership_type, @individual_lessons_count, @price OUTPUT
INSERT INTO Абонемент
	VALUES
	(@client, @membership_type, @individual_lessons_count, @price)
DECLARE @membership int
SELECT @membership = @@identity
DECLARE @style int
SELECT @style = Стиль
	FROM [Вид абонемента]
	WHERE ID = @membership_type
DECLARE @min_clients_group int = 0
DECLARE @min_client_count int = 999
DECLARE @group int
DECLARE Group_cursor CURSOR LOCAL
FOR 
	SELECT ID
		FROM Группа
		WHERE Стиль = @style
	OPEN Group_cursor
	FETCH NEXT FROM Group_cursor INTO @group
	WHILE @@FETCH_STATUS = 0
		BEGIN
			DECLARE @client_count int
			SELECT @client_count = COUNT(ID)
				FROM Абонемент JOIN [Абонементы групп] ON Абонемент.ID = [Абонементы групп].Абонемент
				WHERE [Абонементы групп].Группа = @group
			IF @client_count < @min_client_count
			BEGIN
				SET @min_clients_group = @group
				SET @min_client_count = @client_count
			END
			FETCH NEXT FROM Group_cursor INTO @group
		END
	CLOSE Group_cursor
DEALLOCATE Group_cursor
IF @min_clients_group = 0 OR @min_client_count = 10
	BEGIN
		DECLARE @group_number int
		DECLARE @max_group_number int = 0
		SELECT @max_group_number = MAX([Номер группы])
			FROM Группа
			WHERE [Номер группы] < @style * 100 + 100
		SET @group_number = @max_group_number + 1
		INSERT INTO Группа
		VALUES
			(@style, @group_number)
		DECLARE @new_group int
		SELECT @new_group = @@identity
		INSERT INTO [Абонементы групп]
		VALUES
			(@membership, @new_group)
	END
ELSE
	BEGIN
		INSERT INTO [Абонементы групп]
		VALUES
			(@membership, @min_clients_group)
	END
GO