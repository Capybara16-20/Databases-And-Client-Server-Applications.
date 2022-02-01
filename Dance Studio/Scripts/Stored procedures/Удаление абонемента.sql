CREATE PROCEDURE [�������� ����������]
(@client_FIO nvarchar(100),
@membership_type nvarchar(100),
@individual_lesson_count int)
AS
BEGIN
	DECLARE @id int
	SELECT @id = ���������.ID
		FROM (��������� JOIN [��� ����������] ON ���������.[��� ����������] = [��� ����������].ID)
					JOIN ������ ON ���������.������ = ������.ID
		WHERE ������.��� = @client_FIO AND [��� ����������].�������� = @membership_type 
									   AND ���������.[���������� �������������� �������] = @individual_lesson_count
	IF @id IS NOT NUlL
		BEGIN
			DELETE FROM [�������������� �������]
				WHERE ��������� = @id
			DELETE FROM [���������� �����]
				WHERE ��������� = @id
			DELETE FROM ���������
				WHERE ID = @id
		END
	ELSE
		PRINT(N'���������� �� ����������!')
END