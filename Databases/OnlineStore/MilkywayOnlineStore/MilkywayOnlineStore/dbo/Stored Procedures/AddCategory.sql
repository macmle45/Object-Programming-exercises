
CREATE PROCEDURE AddCategory
	@Nazwa nvarchar (250)
AS
BEGIN
	INSERT Kategorie
	VALUES (@Nazwa)
END

/*
EXEC AddCategory 'Geologia'

SELECT TOP 1 * FROM Kategorie ORDER BY ID DESC
*/