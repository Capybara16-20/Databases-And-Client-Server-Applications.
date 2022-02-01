CREATE PROCEDURE [���������� ������]
@sketch_id int,
@style_id int,
@size_id int
AS
BEGIN
	DECLARE @time real
	IF EXISTS(SELECT �����.ID
		FROM �����
		WHERE �����.ID = @sketch_id)
		BEGIN
			EXEC [������ ������� ������] @style_id, @size_id, @time OUTPUT
			UPDATE �����
			SET
			����� = @style_id,
			������ = @size_id,
			[����� ���������] = @time
			WHERE ID = @sketch_id
		END
	ELSE
		PRINT(N'������ � ����� ID �� ����������!')
END