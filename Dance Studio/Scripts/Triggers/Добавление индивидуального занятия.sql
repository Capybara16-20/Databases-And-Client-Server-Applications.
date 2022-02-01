CREATE TRIGGER [���������� ��������������� �������]
ON [�������������� �������]
INSTEAD OF INSERT
AS
DECLARE @membership int
DECLARE @teacher int
DECLARE @date date
DECLARE @time time
SELECT @membership = ���������, @teacher = �������������, @date = ����, @time = �����
	FROM inserted
DECLARE @client int
SELECT @client = ������
	FROM ���������
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
IF NOT EXISTS(SELECT �������.ID
	FROM (������� JOIN ������ ON �������.������ = ������.ID)
		JOIN [���������� �����] ON ������.ID = [���������� �����].������
	WHERE ���� = @date AND ����� >= @old_time AND ����� < @new_time AND ������������� = @teacher)
BEGIN
	IF NOT EXISTS(SELECT �������.ID
		FROM (������� JOIN ������ ON �������.������ = ������.ID)
			JOIN [���������� �����] ON ������.ID = [���������� �����].������
		WHERE ���� = @date AND ����� >= @old_time AND ����� < @new_time AND ��������� = @membership)
	BEGIN
		IF NOT EXISTS(SELECT [�������������� �������].ID
			FROM [�������������� �������]
			WHERE ���� = @date AND ����� >= @old_time AND ����� < @new_time AND ������������� = @teacher)
		BEGIN
			IF NOT EXISTS(SELECT [�������������� �������].ID
				FROM [�������������� �������]
				WHERE ���� = @date AND ����� >= @old_time AND ����� < @new_time AND ��������� = @membership)
			BEGIN
				INSERT INTO [�������������� �������]
				VALUES
					(@membership, @teacher, @date, @time)
			END
			ELSE
				PRINT(N'������ ������� �� �������������� ������� � ��� �����!')
		END
		ELSE
			PRINT(N'������������� �������� �������������� ������� � ��� �����!')
	END
	ELSE
		PRINT(N'������ ������� �� ��������� ������� � ��� �����!')
END
ELSE
	PRINT(N'������������� �������� ��������� ������� � ��� �����!')
GO