CREATE TRIGGER [������� ������� �� ����c ����������]
ON [������ �� ����� ����������]
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
	SELECT ������, ������, �����, [��� ������], ����, �����
		FROM inserted
	OPEN Record_cursor
	FETCH NEXT FROM Record_cursor INTO @master, @client, @sketch, @work_type, @date, @time
	WHILE @@FETCH_STATUS = 0
		BEGIN
			DECLARE @work_time int
			DECLARE @price money
			EXEC [������ ������� ������] @work_type, @sketch, @work_time OUTPUT
			EXEC [������ ��������� ������] @master, @work_type, @sketch, @price OUTPUT
			INSERT INTO [������ �� ����� ����������]
			VALUES
				(@master, @client, @sketch, @work_type, @date, @time, @work_time, @price)
			FETCH NEXT FROM Record_cursor INTO @master, @client, @sketch, @work_type, @date, @time
		END
	CLOSE Record_cursor
DEALLOCATE Record_cursor
GO
