CREATE PROCEDURE [���������� ����������]
(@id int,
@client_id int,
@membership_type_id int,
@individual_lesson_count int)
AS
BEGIN
	IF EXISTS(SELECT ID
		FROM ���������
		WHERE ID = @id)
		BEGIN
			DECLARE @price money
			EXEC [C�������� ����������] @membership_type_id, @individual_lesson_count, @price OUTPUT
			UPDATE ���������
			SET
				������ = @client_id,
				[��� ����������] = @membership_type_id,
				[���������� �������������� �������] = @individual_lesson_count,
				��������� = @price
			WHERE ID = @id
		END
	ELSE
		PRINT(N'���������� � ����� ID �� ����������!')
END