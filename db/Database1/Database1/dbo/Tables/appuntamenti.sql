CREATE TABLE [dbo].[Appuntamenti]
(
	[Id] INT identity  PRIMARY KEY NOT NULL, 
    [clienteID] INT foreign key (Id) references clienti(Id) NOT NULL, 
    [appuntamento_Data_tempo]  DATETIME NOT NULL, 
    [parrucchieraID]fk_parrucchiera INT foreign key (Id) references parrucchiera(Id) NOT NULL
)
