CREATE TABLE [dbo].[Rabaty] (
    [ID]       INT IDENTITY (1, 1) NOT NULL,
    [KlientID] INT NULL,
    [Procent]  INT DEFAULT ((5)) NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    CHECK ([Procent]=(30) OR [Procent]=(25) OR [Procent]=(20) OR [Procent]=(15) OR [Procent]=(10) OR [Procent]=(5)),
    FOREIGN KEY ([KlientID]) REFERENCES [dbo].[Klienci] ([ID])
);

