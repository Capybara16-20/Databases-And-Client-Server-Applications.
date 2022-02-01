CREATE PROCEDURE [���������� ������ �� �����]
@record_id int,
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
	IF EXISTS(SELECT [������ �� ����� ����������].ID
		FROM [������ �� ����� ����������]
		WHERE [������ �� ����� ����������].ID = @record_id)
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
											EXEC [������ ������� ������] @work_type_id, @sketch_id, @work_time OUTPUT
											EXEC [������ ��������� ������] @master_id, @work_type_id, @sketch_id, @price OUTPUT
											UPDATE [������ �� ����� ����������]
												SET
													������ = @master_id,
													������ = @client_id,
													����� = @sketch_id,
													[��� ������] = @work_type_id,
													���� = @date,
													����� = @time,
													[����� ������] = @work_time,
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
		PRINT(N'������ �� ������ � ����� ID �� ����������!')
END