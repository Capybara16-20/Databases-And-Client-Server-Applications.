CREATE PROCEDURE [���������� ������]
@style_id int,
@size_id int
AS
BEGIN
	DECLARE @time real
	EXEC [������ ������� ��������� ������] @style_id, @size_id, @time OUTPUT
	INSERT INTO �����
	VALUES
		(@style_id, @size_id, @time)
END