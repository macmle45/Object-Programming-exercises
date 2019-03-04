CREATE TABLE [dbo].[RezerwacjeProduktow] (
    [ID]        INT IDENTITY (1, 1) NOT NULL,
    [KlientID]  INT NULL,
    [ProduktID] INT NULL,
    [StatusID]  INT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    FOREIGN KEY ([KlientID]) REFERENCES [dbo].[Klienci] ([ID]),
    FOREIGN KEY ([ProduktID]) REFERENCES [dbo].[Produkty] ([ID]),
    FOREIGN KEY ([StatusID]) REFERENCES [dbo].[StatusyRezerwacji] ([ID])
);

