CREATE PROCEDURE [Cтоимость абонемента]
@membership_type_id int,
@individual_lesson_count int,
@price money OUTPUT
AS
	BEGIN
	DECLARE @training_count real
	DECLARE @traiing_price money
	IF EXISTS(SELECT ID
		FROM [Вид абонемента]
		WHERE ID = @membership_type_id)
		BEGIN
			SELECT @training_count = [Количество тренировок]
				FROM [Вид абонемента]
				WHERE ID = @membership_type_id
			SELECT @traiing_price = [Стоимость одного занятия]
				FROM Стиль JOIN [Вид абонемента] ON Стиль.ID = [Вид абонемента].Стиль
				WHERE [Вид абонемента].ID = @membership_type_id
			SET @price = @traiing_price * @training_count + 1000 * @individual_lesson_count
		END
	ELSE
		PRINT(N'Вида абонемента с таким ID не существует!')
END