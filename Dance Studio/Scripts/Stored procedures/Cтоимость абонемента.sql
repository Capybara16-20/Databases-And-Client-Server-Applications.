CREATE PROCEDURE [C�������� ����������]
@membership_type_id int,
@individual_lesson_count int,
@price money OUTPUT
AS
	BEGIN
	DECLARE @training_count real
	DECLARE @traiing_price money
	IF EXISTS(SELECT ID
		FROM [��� ����������]
		WHERE ID = @membership_type_id)
		BEGIN
			SELECT @training_count = [���������� ����������]
				FROM [��� ����������]
				WHERE ID = @membership_type_id
			SELECT @traiing_price = [��������� ������ �������]
				FROM ����� JOIN [��� ����������] ON �����.ID = [��� ����������].�����
				WHERE [��� ����������].ID = @membership_type_id
			SET @price = @traiing_price * @training_count + 1000 * @individual_lesson_count
		END
	ELSE
		PRINT(N'���� ���������� � ����� ID �� ����������!')
END