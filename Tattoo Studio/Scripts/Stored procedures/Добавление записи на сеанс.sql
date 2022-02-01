CREATE PROCEDURE [���������� ������ �� �����]
@master_id int,
@client_id int,
@sketch_id int,
@work_type_id int,
@date date,
@time time
AS
BEGIN
	DECLARE @work_time real
	DECLARE @price money
	EXEC [������ ������� ������] @work_type_id, @sketch_id, @work_time OUTPUT
	EXEC [������ ��������� ������] @master_id, @work_type_id, @sketch_id, @price OUTPUT
	INSERT INTO [������ �� ����� ����������]
	VALUES
		(@master_id, @client_id, @sketch_id, @work_type_id, @date, @time, @work_time, @price)
END