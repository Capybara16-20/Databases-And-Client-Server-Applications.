CREATE PROCEDURE [���������� ������ �� ������]
@record_id int,
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
	IF EXISTS(SELECT [������ �� ������].ID
		FROM [������ �� ������]
		WHERE [������ �� ������].ID = @record_id)
		BEGIN
			IF EXISTS(SELECT ������.ID
				FROM ������
				WHERE ������.ID = @master_id)
				BEGIN
					IF EXISTS(SELECT ������.ID
						FROM ������
						WHERE ������.ID = @client_id)
						BEGIN
							IF EXISTS(SELECT ������.ID
								FROM ������
								WHERE ������.ID = @client_id)
								BEGIN
									IF EXISTS(SELECT ������.ID
										FROM ������
										WHERE ������.ID = @client_id)
										BEGIN
											UPDATE [������ �� ������]
												SET
													������ = @master_id,
													������ = @client_id,
													[��� ������] = @service_type_id,
													���� = @date,
													����� = @time,
													���� = @price
												WHERE ID = @record_id
										END
									ELSE
										PRINT(N'���� ������ � ����� ID �� ����������!')
								END
							ELSE
								PRINT(N'������ � ����� ID �� ����������!')
						END
					ELSE
						PRINT(N'������� � ����� ID �� ����������!')
				END
			ELSE
				PRINT(N'������� � ����� ID �� ����������!')
		END
	ELSE
		PRINT(N'������ �� ����� � ����� ID �� ����������!')
END