﻿CREATE TABLE [dbo].[Appuntamenti]
(
	[Id] INT identity NOT NULL PRIMARY KEY, 
    [clienteID] INT NOT NULL, 
    [appuntamento_Data_tempo] DATETIME NOT NULL
)