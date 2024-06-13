CREATE TABLE [dbo].[Appuntamenti]
(
	[Id] INT identity  PRIMARY KEY NOT NULL, 
  [clienteID]     int  NOT NULL, 
    [appuntamento_Data_tempo]  DATETIME NOT NULL, 
    [parrucchieraID] INT NOT NULL,
   CONSTRAINT FK_appuntamenti_clienteid FOREIGN KEY ([clienteID]) REFERENCES [dbo].[clienti]([Id]),
   CONSTRAINT FK_appuntamenti_parrucchieraID FOREIGN KEY ([parrucchieraID]) REFERENCES [dbo].[parrucchieri]([Id])
   
   

)
