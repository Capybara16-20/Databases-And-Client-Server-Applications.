CREATE PROCEDURE [”даление эскиза]
@sketch_id int,
@message nvarchar(100) OUTPUT
AS
BEGIN
	IF EXISTS(SELECT Ёскиз.ID
		FROM Ёскиз
		WHERE Ёскиз.ID = @sketch_id)
		BEGIN
			IF NOT EXISTS (SELECT Ёскиз
				FROM [«апись на сеанс татуировки]
				WHERE Ёскиз = @sketch_id)
			BEGIN
				DELETE FROM Ёскиз
				WHERE Ёскиз.ID = @sketch_id
			END
			ELSE
				BEGIN
					PRINT(N'Ќельз€ удалить эскиз, участвующий в сеансе!')
					SET @message = N'Ќельз€ удалить эскиз, участвующий в сеансе!';
				END
		END
	ELSE
		BEGIN
			PRINT(N'Ёскиза с таким ID не существует!')
			SET @message = N'Ёскиза с таким ID не существует!';
		END
END