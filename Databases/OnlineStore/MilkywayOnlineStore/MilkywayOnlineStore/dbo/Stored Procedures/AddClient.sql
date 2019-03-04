
CREATE PROCEDURE AddClient
	@Imię nvarchar (50),
	@Nazwisko nvarchar (100),
	@Email nvarchar (250),
	@Telefon nvarchar (20)
AS
BEGIN
	INSERT Klienci
	VALUES (@Imię, @Nazwisko, @Email, @Telefon)
END

/*
EXEC AddClient 'Wojciech', 'Kowalski', 'wojciech.kowalski@gmail.com', '456135912'

SELECT TOP 1 * FROM Klienci ORDER BY ID DESC
*/