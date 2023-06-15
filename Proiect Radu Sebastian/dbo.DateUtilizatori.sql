CREATE TABLE [dbo].[DateUtilizatori] (
    [ID]       INT            IDENTITY (1, 1) NOT NULL,
    [Nume]     NVARCHAR (50)  NOT NULL,
    [Prenume]  NVARCHAR (50)  NOT NULL,
    [Email]    NVARCHAR (100) NOT NULL,
    [Economii] INT            NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

