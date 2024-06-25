CREATE TABLE [dbo].[dettagli appuntamento]
(
	[Id] INT identity NOT NULL PRIMARY KEY, 



    [appuntamentoID] INT  not NULL,
   [ServiziID] INT  not NULL,
    [clienteID] INT  not NULL,
   
    CONSTRAINT FK_clienteid_appuntamentoID FOREIGN KEY ([clienteID]) REFERENCES [dbo].[clienti]([Id]),
    CONSTRAINT FK_appuntamentid_appuntamentoID FOREIGN KEY ([appuntamentoID]) REFERENCES [dbo].[appuntamenti]([Id]),
    CONSTRAINT FK_serviziid_ServizioID FOREIGN KEY ([serviziID]) REFERENCES [dbo].[Servizi]([Id])
)
--foreign key