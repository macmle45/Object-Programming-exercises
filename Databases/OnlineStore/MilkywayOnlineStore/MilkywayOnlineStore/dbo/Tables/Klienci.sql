CREATE TABLE [dbo].[Klienci] (
    [ID]       INT            IDENTITY (1, 1) NOT NULL,
    [Imię]     NVARCHAR (250) NOT NULL,
    [Nazwisko] NVARCHAR (250) NOT NULL,
    [Email]    NVARCHAR (250) NOT NULL,
    [Telefon]  NVARCHAR (20)  NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

