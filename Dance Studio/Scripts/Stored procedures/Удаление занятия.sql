CREATE PROCEDURE [�������� �������]
(@teacher_FIO nvarchar(100),
@date date,
@time time)
AS
BEGIN
	DECLARE @id int
	SELECT @id = �������.ID
		FROM ������� JOIN ������������� ON �������.������������� = �������������.ID
		WHERE �������������.��� = @teacher_FIO AND �������.���� = @date AND �������.����� = @time

	IF @id IS NOT NUlL
		BEGIN
			DELETE FROM �������
				WHERE ID = @id
		END
	ELSE
		PRINT(N'������� �� ����������!')
END