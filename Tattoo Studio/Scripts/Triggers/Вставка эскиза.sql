CREATE TRIGGER [Вставка эскиза]
ON Эскиз
INSTEAD OF INSERT
AS
DECLARE @style int
DECLARE @size int
SELECT @style = Стиль, @size = Размер
	FROM inserted
DECLARE @time real
EXEC [Расчёт времени нанесения эскиза] @style, @size, @time OUTPUT
INSERT INTO Эскиз
	VALUES
	(@style, @size, @time)
GO
