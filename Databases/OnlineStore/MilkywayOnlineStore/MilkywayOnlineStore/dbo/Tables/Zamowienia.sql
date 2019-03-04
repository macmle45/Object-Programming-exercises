CREATE TABLE [dbo].[Zamowienia] (
    [ID]              INT            IDENTITY (1, 1) NOT NULL,
    [KlientID]        INT            NULL,
    [ProduktID]       INT            NULL,
    [DataZamowienia]  DATETIME       NOT NULL,
    [Kwota]           DECIMAL (8, 2) NOT NULL,
    [RodzajDostawyID] INT            NULL,
    [DostawcaID]      INT            NULL,
    [StatusID]        INT            NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    FOREIGN KEY ([DostawcaID]) REFERENCES [dbo].[Kurierzy] ([ID]),
    FOREIGN KEY ([KlientID]) REFERENCES [dbo].[Klienci] ([ID]),
    FOREIGN KEY ([ProduktID]) REFERENCES [dbo].[Produkty] ([ID]),
    FOREIGN KEY ([RodzajDostawyID]) REFERENCES [dbo].[RodzajDostawy] ([ID]),
    FOREIGN KEY ([StatusID]) REFERENCES [dbo].[StatusyZamowien] ([ID])
);

