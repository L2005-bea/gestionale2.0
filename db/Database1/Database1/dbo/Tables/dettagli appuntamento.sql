CREATE TABLE [dbo].[dettagli appuntamento]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [appuntamentID] INT NULL, 
    [servizioID] INT NULL, 
    [clienteID] INT NULL
)
