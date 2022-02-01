CREATE PROCEDURE [Обновление абонемента]
(@id int,
@client_id int,
@membership_type_id int,
@individual_lesson_count int)
AS
BEGIN
	IF EXISTS(SELECT ID
		FROM Абонемент
		WHERE ID = @id)
		BEGIN
			DECLARE @price money
			EXEC [Cтоимость абонемента] @membership_type_id, @individual_lesson_count, @price OUTPUT
			UPDATE Абонемент
			SET
				Клиент = @client_id,
				[Вид абонемента] = @membership_type_id,
				[Количество индивидуальных занятий] = @individual_lesson_count,
				Стоимость = @price
			WHERE ID = @id
		END
	ELSE
		PRINT(N'Абонемента с таким ID не существует!')
END