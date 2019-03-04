CREATE VIEW [dbo].[v_AktualneZamowienia]
AS
SELECT Klienci.Imię + ' ' + Klienci.Nazwisko AS ImieNazwisko,
	Zamowienia.ID AS NrZamowienia, Produkty.Nazwa AS NazwaProduktu,
	RodzajDostawy.Nazwa AS SposobDoreczenia,
	StatusyZamowien.Nazwa AS StatZam
FROM
	Zamowienia
	LEFT JOIN Klienci ON Zamowienia.KlientID = Klienci.ID
	LEFT JOIN Produkty ON Zamowienia.ProduktID = Produkty.ID
	LEFT JOIN RodzajDostawy ON Zamowienia.RodzajDostawyID = RodzajDostawy.ID
	LEFT JOIN StatusyZamowien ON Zamowienia.StatusID = StatusyZamowien.ID
WHERE StatusyZamowien.Nazwa != 'Zakończone'