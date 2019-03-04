CREATE VIEW [dbo].[v_SzczegolyProduktow]
AS
SELECT Produkty.Nazwa AS NazwaProduktu, 
	Marki.Nazwa AS Marka, Kategorie.Nazwa AS Kategoria,
	Produkty.Cena AS Cena, Produkty.StanMagazynowy AS Ilosc
FROM
	Produkty
	LEFT JOIN Marki ON Produkty.MarkaID = Marki.ID
	LEFT JOIN Kategorie ON Produkty.KategoriaID = Kategorie.ID