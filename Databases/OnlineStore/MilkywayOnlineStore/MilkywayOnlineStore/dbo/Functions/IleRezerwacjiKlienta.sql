
CREATE FUNCTION IleRezerwacjiKlienta
	(@KlientID INT)
RETURNS INT
AS
BEGIN
			
	DECLARE @iloscRezerwacjiKlienta INT
	SET @iloscRezerwacjiKlienta =	(
					SELECT COUNT(*)
					FROM RezerwacjeProduktow
					WHERE KlientID = @KlientID
				)
	RETURN @iloscRezerwacjiKlienta
END