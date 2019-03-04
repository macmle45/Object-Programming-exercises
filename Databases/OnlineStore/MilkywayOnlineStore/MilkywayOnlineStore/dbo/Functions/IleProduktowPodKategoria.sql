
CREATE FUNCTION IleProduktowPodKategoria
	(@KategoriaID INT)
RETURNS INT
AS
BEGIN
			
	DECLARE @iloscProduktow INT
	SET @iloscProduktow =	(
					SELECT COUNT(*)
					FROM Produkty
					WHERE KategoriaID = @KategoriaID
				)
	RETURN @iloscProduktow
END