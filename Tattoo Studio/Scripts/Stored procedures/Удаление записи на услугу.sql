CREATE PROCEDURE [�������� ������ �� ������]
@record_id int
AS
BEGIN
	IF EXISTS(SELECT [������ �� ������].ID
		FROM [������ �� ������]
		WHERE [������ �� ������].ID = @record_id)
		BEGIN
			DELETE FROM [������ �� ������]
			WHERE [������ �� ������].ID = @record_id
		END
	ELSE
		PRINT(N'������ �� ������ � ����� ID �� ����������!')
END