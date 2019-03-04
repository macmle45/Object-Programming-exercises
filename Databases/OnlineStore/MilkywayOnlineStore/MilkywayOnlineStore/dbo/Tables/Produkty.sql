CREATE TABLE [dbo].[Produkty] (
    [ID]             INT            IDENTITY (1, 1) NOT NULL,
    [Nazwa]          NVARCHAR (250) NOT NULL,
    [Opis]           NVARCHAR (250) NULL,
    [MarkaID]        INT            NULL,
    [KategoriaID]    INT            NULL,
    [StanMagazynowy] INT            NOT NULL,
    [Cena]           DECIMAL (8, 2) NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    FOREIGN KEY ([KategoriaID]) REFERENCES [dbo].[Kategorie] ([ID]),
    FOREIGN KEY ([MarkaID]) REFERENCES [dbo].[Marki] ([ID]),
    UNIQUE NONCLUSTERED ([Nazwa] ASC)
);

