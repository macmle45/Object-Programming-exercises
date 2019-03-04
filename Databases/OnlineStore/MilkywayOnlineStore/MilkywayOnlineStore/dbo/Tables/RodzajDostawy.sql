CREATE TABLE [dbo].[RodzajDostawy] (
    [ID]    INT            IDENTITY (1, 1) NOT NULL,
    [Nazwa] NVARCHAR (250) NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    UNIQUE NONCLUSTERED ([Nazwa] ASC)
);

