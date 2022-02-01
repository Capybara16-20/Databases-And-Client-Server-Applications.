CREATE PROCEDURE [������ ������� ������]
@work_type_id int,
@sketch_id int,
@time real OUTPUT
AS
	BEGIN
	DECLARE @basetime real
	DECLARE @size_coef real
	DECLARE @style_coef real
	IF EXISTS(SELECT [��� ������].[��������� �����]
		FROM [��� ������]
		WHERE [��� ������].ID = @work_type_id)
		BEGIN
			IF EXISTS(SELECT �����.ID
				FROM �����
				WHERE �����.ID = @sketch_id)
				BEGIN
					SELECT @basetime = [��� ������].[��������� �����]
						FROM [��� ������]
						WHERE [��� ������].ID = @work_type_id
					SELECT @size_coef = ������.[����������� �������]
						FROM ����� INNER JOIN ������ ON �����.������ = ������.ID
						WHERE �����.ID = @sketch_id
					SELECT @style_coef = �����.[����������� �������]
						FROM ����� INNER JOIN ����� ON �����.����� = �����.ID
						WHERE �����.ID = @sketch_id
					SET @time = @basetime * @size_coef * @style_coef
				END
			ELSE
				PRINT(N'������ � ����� ID �� ����������!')
		END
	ELSE
		PRINT(N'���� ������ � ����� ID �� ����������!')
END