CREATE PROCEDURE [������� �������]
(@group_id int,
@training_hall_id int,
@teacher_id int,
@style_id int,
@date date,
@time time)
AS
BEGIN
INSERT INTO �������
VALUES
 (@group_id, @training_hall_id, @teacher_id, @style_id, @date, @time)
END