CREATE TABLE [dbo].[dettagli appuntamento]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [appuntamentID] INT NOT NULL, 
    [servizioID] INT NOT NULL, 
    [clienteID] INT NOT NULL
)
