CREATE TRIGGER [���������� ����������]
ON ���������
INSTEAD OF INSERT
AS
DECLARE @client int
DECLARE @membership_type int
DECLARE @individual_lessons_count int
SELECT @client = ������, @membership_type = [��� ����������], @individual_lessons_count = [���������� �������������� �������]
	FROM inserted
DECLARE @price real
EXEC [C�������� ����������] @membership_type, @individual_lessons_count, @price OUTPUT
INSERT INTO ���������
	VALUES
	(@client, @membership_type, @individual_lessons_count, @price)
DECLARE @membership int
SELECT @membership = @@identity
DECLARE @style int
SELECT @style = �����
	FROM [��� ����������]
	WHERE ID = @membership_type
DECLARE @min_clients_group int = 0
DECLARE @min_client_count int = 999
DECLARE @group int
DECLARE Group_cursor CURSOR LOCAL
FOR 
	SELECT ID
		FROM ������
		WHERE ����� = @style
	OPEN Group_cursor
	FETCH NEXT FROM Group_cursor INTO @group
	WHILE @@FETCH_STATUS = 0
		BEGIN
			DECLARE @client_count int
			SELECT @client_count = COUNT(ID)
				FROM ��������� JOIN [���������� �����] ON ���������.ID = [���������� �����].���������
				WHERE [���������� �����].������ = @group
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
		SELECT @max_group_number = MAX([����� ������])
			FROM ������
			WHERE [����� ������] < @style * 100 + 100
		SET @group_number = @max_group_number + 1
		INSERT INTO ������
		VALUES
			(@style, @group_number)
		DECLARE @new_group int
		SELECT @new_group = @@identity
		INSERT INTO [���������� �����]
		VALUES
			(@membership, @new_group)
	END
ELSE
	BEGIN
		INSERT INTO [���������� �����]
		VALUES
			(@membership, @min_clients_group)
	END
GO