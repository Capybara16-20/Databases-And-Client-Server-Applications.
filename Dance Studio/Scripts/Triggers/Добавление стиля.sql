CREATE TRIGGER [���������� �����]
ON �����
AFTER UPDATE
AS
DECLARE @style nvarchar(100)
DECLARE @price money
DECLARE Style_cursor CURSOR LOCAL
FOR 
	SELECT ID, [��������� ������ �������]
		FROM inserted
	OPEN Style_cursor
	FETCH NEXT FROM Style_cursor INTO @style, @price
	WHILE @@FETCH_STATUS = 0
		BEGIN
			DECLARE @membership int
			DECLARE @membership_type int
			DECLARE @individual_lessons_count int
			DECLARE Membership_cursor CURSOR LOCAL
			FOR 
				SELECT ���������.ID, [��� ����������], [���������� �������������� �������]
					FROM ��������� JOIN [��� ����������] ON ���������.[��� ����������] = [��� ����������].ID
					WHERE ����� = @style
				OPEN Membership_cursor
				FETCH NEXT FROM Membership_cursor INTO @membership, @membership_type, @individual_lessons_count
				WHILE @@FETCH_STATUS = 0
					BEGIN
						DECLARE @new_price money
						EXEC [C�������� ����������] @membership_type, @individual_lessons_count, @new_price OUTPUT
						UPDATE ���������
						SET
							��������� = @new_price
						WHERE ID = @membership
						FETCH NEXT FROM Membership_cursor INTO @membership, @membership_type, @individual_lessons_count
					END
					CLOSE Membership_cursor
				DEALLOCATE Membership_cursor
			FETCH NEXT FROM Style_cursor INTO @style, @price
		END
	CLOSE Style_cursor
DEALLOCATE Style_cursor
GO