insert into servizi
values 
('Coroncine intrecciate ','Capelli intrecciati e avvolti intorno alla testa, creando un effetto a corona',50),
('Raccolti','Capelli acconciati, lontano dal collo, spesso in disegni intricati, adatti per eventi formali.',20),
 ('Taglio corto', 'Taglio di capelli corto alla moda', 30),
  ( 'Colore Balayage', 'Balayage per un look naturale e luminoso', 50),
  ( 'Trecce africane', 'Acconciatura con trecce a cornrows', 60),
  ('Extension capelli lisci', 'Extension per capelli lisci con clip', 70),
  ('Taglio lungo scalato', 'Taglio lungo con scalatura per un look dinamico', 45),
  ('M�ches', 'Colore m�ches per illuminare il viso', 55)

INSERT INTO parrucchieri (nome, cognome, email, telefono, codice_immagine)
VALUES 
('alice','marchesi','marchesi.a@email.com', '33836760','avatar1.png'),
('lara','deserto', 'deserto.l@email.com','33988973','avatar2.png'),
('Luca', 'Bianchi', 'luca.bianchi@email.com', '3802468112','avatar3.png'),
( 'Anna', 'Neri', 'anna.neri@email.com', '3661122334','avatar4.png'),
('Marco', 'Gialli', 'marco.gialli@email.com', '3456789012','avatar5.png'),
 ('Laura', 'Rosa', 'laura.rosa@email.com', '3209876543','avatar6.png')



 insert into clienti
 values
 ('John', 'Doe', 'john.doe@example.com', '123-456-7890'),
('Jane', 'Smith', 'jane.smith@example.com', '234-567-8901'),
('Robert', 'Brown', 'robert.brown@example.com', '345-678-9012'),
('Emily', 'Davis', 'emily.davis@example.com', '456-789-0123'),
('Michael', 'Wilson', 'michael.wilson@example.com', '567-890-1234'),
('Sarah', 'Taylor', 'sarah.taylor@example.com', '678-901-2345'),
('David', 'Anderson', 'david.anderson@example.com', '789-012-3456'),
('Laura', 'Thomas', 'laura.thomas@example.com', '890-123-4567'),
('James', 'Jackson', 'james.jackson@example.com', '901-234-5678'),
('Linda', 'White', 'linda.white@example.com', '012-345-6789');


DECLARE @StartDate AS DATETIME = GETDATE()
DECLARE @EndDate AS DATETIME = GETDATE()+365

insert into Appuntamenti (clienteID,appuntamento_Data_tempo,parrucchieraID)
select 
	c.id,
	DATEADD(HOUR,RAND(CHECKSUM(NEWID()))*(1+DATEDIFF(DAY, @StartDate, @EndDate)),
	DATEADD(DAY, RAND(CHECKSUM(NEWID()))*(1+DATEDIFF(DAY, @StartDate, @EndDate)),@StartDate)),
	p.Id 
from clienti c
cross join parrucchieri p


