CREATE PROCEDURE [�������� ������]
@sketch_id int,
@message nvarchar(100) OUTPUT
AS
BEGIN
	IF EXISTS(SELECT �����.ID
		FROM �����
		WHERE �����.ID = @sketch_id)
		BEGIN
			IF NOT EXISTS (SELECT �����
				FROM [������ �� ����� ����������]
				WHERE ����� = @sketch_id)
			BEGIN
				DELETE FROM �����
				WHERE �����.ID = @sketch_id
			END
			ELSE
				BEGIN
					PRINT(N'������ ������� �����, ����������� � ������!')
					SET @message = N'������ ������� �����, ����������� � ������!';
				END
		END
	ELSE
		BEGIN
			PRINT(N'������ � ����� ID �� ����������!')
			SET @message = N'������ � ����� ID �� ����������!';
		END
END