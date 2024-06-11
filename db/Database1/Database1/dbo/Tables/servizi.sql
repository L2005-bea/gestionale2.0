CREATE TABLE [dbo].[servizi]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [nome_servizio] VARCHAR(50) NOT NULL, 
    [descrizione_servizio] VARCHAR(200) NOT NUlL, 
    [prezzo] DECIMAL(4, 2) NOT NULL

)
--identity 