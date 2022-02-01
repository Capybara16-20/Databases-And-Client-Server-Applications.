CREATE PROCEDURE [Обновление занятия]
(@id int,
@group_id int,
@training_hall_id int,
@teacher_id int,
@style_id int,
@date date,
@time time)
AS
BEGIN
	IF EXISTS(SELECT ID
		FROM Занятие
		WHERE ID = @id)
		BEGIN
			UPDATE Занятие
			SET
				Группа = @group_id,
				Зал = @training_hall_id,
				Преподаватель = @teacher_id,
				Стиль = @style_id,
				Дата = @date,
				@time = @time
			WHERE ID = @id
		END
	ELSE
		PRINT(N'Занятия с таким ID не существует!')
END