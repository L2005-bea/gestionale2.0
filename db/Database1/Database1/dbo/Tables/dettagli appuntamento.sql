CREATE TABLE [dbo].[dettagli appuntamento]
(
	[Id] INT identity NOT NULL PRIMARY KEY, 
   [servizioID] int foreign key (Id) references servizi(Id) NOT NULL,

    [clienteID] INT foreign key (Id) references clienti(Id) NOT NULL, 
    [appuntamentoID] INT  foreign key (Id) references appuntamenti(Id) not NULL
)
--foreign key