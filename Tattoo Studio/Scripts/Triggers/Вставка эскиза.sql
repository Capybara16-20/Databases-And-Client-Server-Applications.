CREATE TRIGGER [������� ������]
ON �����
INSTEAD OF INSERT
AS
DECLARE @style int
DECLARE @size int
SELECT @style = �����, @size = ������
	FROM inserted
DECLARE @time real
EXEC [������ ������� ��������� ������] @style, @size, @time OUTPUT
INSERT INTO �����
	VALUES
	(@style, @size, @time)
GO
