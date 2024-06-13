CREATE TABLE [dbo].[dettagli appuntamento]
(
	[Id] INT identity NOT NULL PRIMARY KEY, 
   [servizioID] int  NOT NULL,


    [appuntamentoID] INT  not NULL,
   
    CONSTRAINT FK_appuntamentid_servizioID FOREIGN KEY ([servizioID]) REFERENCES [dbo].[servizi]([Id]),
    CONSTRAINT FK_appuntamentid_appuntamentoID FOREIGN KEY ([appuntamentoID]) REFERENCES [dbo].[appuntamenti]([Id])
)
--foreign key