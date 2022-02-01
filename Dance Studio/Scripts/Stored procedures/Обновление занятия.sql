CREATE PROCEDURE [���������� �������]
(@id int,
@group_id int,
@training_hall_id int,
@teacher_id int,
@style_id int,
@date date,
@time time)
AS
BEGIN
	IF EXISTS(SELECT ID
		FROM �������
		WHERE ID = @id)
		BEGIN
			UPDATE �������
			SET
				������ = @group_id,
				��� = @training_hall_id,
				������������� = @teacher_id,
				����� = @style_id,
				���� = @date,
				@time = @time
			WHERE ID = @id
		END
	ELSE
		PRINT(N'������� � ����� ID �� ����������!')
END