CREATE PROCEDURE [Удаление абонемента]
(@client_FIO nvarchar(100),
@membership_type nvarchar(100),
@individual_lesson_count int)
AS
BEGIN
	DECLARE @id int
	SELECT @id = Абонемент.ID
		FROM (Абонемент JOIN [Вид абонемента] ON Абонемент.[Вид абонемента] = [Вид абонемента].ID)
					JOIN Клиент ON Абонемент.Клиент = Клиент.ID
		WHERE Клиент.ФИО = @client_FIO AND [Вид абонемента].Название = @membership_type 
									   AND Абонемент.[Количество индивидуальных занятий] = @individual_lesson_count
	IF @id IS NOT NUlL
		BEGIN
			DELETE FROM [Индивидуальное занятие]
				WHERE Абонемент = @id
			DELETE FROM [Абонементы групп]
				WHERE Абонемент = @id
			DELETE FROM Абонемент
				WHERE ID = @id
		END
	ELSE
		PRINT(N'Абонемента не существует!')
END