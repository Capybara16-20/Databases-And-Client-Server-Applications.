CREATE PROCEDURE [���������� ������ �� ������]
@master_id int,
@client_id int,
@service_type_id int,
@date date,
@time time
AS
BEGIN
	DECLARE @price money
	SELECT @price = ���������
	FROM [��� ������]
	WHERE ID = @service_type_id
	INSERT INTO [������ �� ������]
	VALUES
		(@master_id, @client_id, @service_type_id, @date, @time, @price)
END