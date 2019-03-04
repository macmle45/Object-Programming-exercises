
CREATE FUNCTION IleZamowienKlienta
	(@KlientID INT)
RETURNS INT
AS
BEGIN
			
	DECLARE @iloscZamowienKlienta INT
	SET @iloscZamowienKlienta =	(
					SELECT COUNT(*)
					FROM Zamowienia
					WHERE KlientID = @KlientID
				)
	RETURN @iloscZamowienKlienta
END