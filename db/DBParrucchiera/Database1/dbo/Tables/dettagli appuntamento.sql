CREATE TABLE [dbo].[dettagli appuntamento]
(
	[Id] INT identity NOT NULL PRIMARY KEY, 



    [appuntamentoID] INT  not NULL,
   
    CONSTRAINT FK_appuntamentid_appuntamentoID FOREIGN KEY ([appuntamentoID]) REFERENCES [dbo].[appuntamenti]([Id])
)
--foreign key