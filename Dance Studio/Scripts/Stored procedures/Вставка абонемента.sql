CREATE PROCEDURE [������� ����������]
(@client_id int,
@membership_type_id int,
@individual_lesson_count int)
AS
BEGIN
	DECLARE @price money
	EXEC [C�������� ����������] @membership_type_id, @individual_lesson_count, @price OUTPUT
	INSERT INTO ���������
	VALUES
		(@client_id, @membership_type_id, @individual_lesson_count, @price)
END