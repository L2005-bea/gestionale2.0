CREATE TABLE [dbo].[dettagli appuntamento]
(
	[Id] INT identity NOT NULL PRIMARY KEY, 
   [servizioID] int  NOT NULL,

    [clienteID] INT  NOT NULL, 
    [appuntamentoID] INT  not NULL,
    CONSTRAINT FK_appuntamentid_clienteID FOREIGN KEY ([clienteID]) REFERENCES [dbo].[clienti]([Id]),
    CONSTRAINT FK_appuntamentid_servizioID FOREIGN KEY ([servizioID]) REFERENCES [dbo].[servizi]([Id]),
    CONSTRAINT FK_appuntamentid_appuntamentoID FOREIGN KEY ([appuntamentoID]) REFERENCES [dbo].[appuntamenti]([Id])
)
--foreign key