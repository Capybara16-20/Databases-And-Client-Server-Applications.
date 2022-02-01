CREATE PROCEDURE [������ ������� ��������� ������]
@style_id int,
@size_id int,
@time real OUTPUT
AS
BEGIN
	DECLARE @basetime real
	DECLARE @style_coef real
	DECLARE @size_coef real
	IF EXISTS(SELECT �����.ID
		FROM �����
		WHERE �����.ID = @style_id)
		BEGIN
			IF EXISTS(SELECT ������.ID
				FROM ������
				WHERE ������.ID = @size_id)
				BEGIN
					SELECT @basetime = [��� ������].[��������� �����]
						FROM [��� ������]
						WHERE [��� ������].ID = 1
					SELECT @size_coef = ������.[����������� �������]
						FROM ������
						WHERE ������.ID = @size_id
					SELECT @style_coef = �����.[����������� �������]
						FROM �����
						WHERE �����.ID = @style_id
					SET @time = @basetime * @size_coef * @style_coef
				END
			ELSE
				PRINT(N'������� � ����� ID �� ����������!')
		END
	ELSE
		PRINT(N'����� � ����� ID �� ����������!')
END