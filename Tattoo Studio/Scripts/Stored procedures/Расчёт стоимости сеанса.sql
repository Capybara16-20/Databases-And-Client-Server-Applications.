CREATE PROCEDURE [������ ��������� ������]
@master_id int,
@work_type_id int,
@sketch_id int,
@price money OUTPUT
AS
	BEGIN
	DECLARE @time real
	DECLARE @master_rate int
	IF EXISTS(SELECT ������.ID
		FROM ������
		WHERE ������.ID = @master_id)
		BEGIN
			IF EXISTS(SELECT [��� ������].ID
				FROM [��� ������]
				WHERE [��� ������].ID = @work_type_id)
				BEGIN
					IF EXISTS(SELECT �����.ID
						FROM �����
						WHERE �����.ID = @sketch_id)
						BEGIN
							SELECT @master_rate = �������������.[������ �� ��� ������]
								FROM ������������� INNER JOIN ������ ON �������������.ID = ������.�������������
								WHERE ������.ID = @master_id
							EXEC [������ ������� ������] @work_type_id, @sketch_id, @time OUTPUT
							SET @price = @master_rate * @time
						END
					ELSE
						PRINT(N'������ � ����� ID �� ����������!')
				END
			ELSE
				PRINT(N'���� ������ � ����� ID �� ����������!')
		END
	ELSE
		PRINT(N'������� � ����� ID �� ����������!')
END