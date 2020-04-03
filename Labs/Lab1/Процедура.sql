CREATE PROCEDURE toName (@cipher int,@name nchar(50) OUTPUT) AS
 SELECT @name = Название 
  FROM Книги 
  WHERE Шифр = @cipher
