CREATE PROCEDURE [Удаление занятия]
(@teacher_FIO nvarchar(100),
@date date,
@time time)
AS
BEGIN
	DECLARE @id int
	SELECT @id = Занятие.ID
		FROM Занятие JOIN Преподаватель ON Занятие.Преподаватель = Преподаватель.ID
		WHERE Преподаватель.ФИО = @teacher_FIO AND Занятие.Дата = @date AND Занятие.Время = @time

	IF @id IS NOT NUlL
		BEGIN
			DELETE FROM Занятие
				WHERE ID = @id
		END
	ELSE
		PRINT(N'Занятия не существует!')
END