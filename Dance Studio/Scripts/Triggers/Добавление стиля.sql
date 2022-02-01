CREATE TRIGGER [Обновление стиля]
ON Стиль
AFTER UPDATE
AS
DECLARE @style nvarchar(100)
DECLARE @price money
DECLARE Style_cursor CURSOR LOCAL
FOR 
	SELECT ID, [Стоимость одного занятия]
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
				SELECT Абонемент.ID, [Вид абонемента], [Количество индивидуальных занятий]
					FROM Абонемент JOIN [Вид абонемента] ON Абонемент.[Вид абонемента] = [Вид абонемента].ID
					WHERE Стиль = @style
				OPEN Membership_cursor
				FETCH NEXT FROM Membership_cursor INTO @membership, @membership_type, @individual_lessons_count
				WHILE @@FETCH_STATUS = 0
					BEGIN
						DECLARE @new_price money
						EXEC [Cтоимость абонемента] @membership_type, @individual_lessons_count, @new_price OUTPUT
						UPDATE Абонемент
						SET
							Стоимость = @new_price
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