CREATE TABLE `clienti` (
  `clienteID` int PRIMARY KEY AUTO_INCREMENT,
  `nome` varchar(255),
  `cognome` varchar(255),
  `Email` varchar(255),
  `numtelefono` varchar(255)
);

CREATE TABLE `servizio` (
  `servizioID` int PRIMARY KEY AUTO_INCREMENT,
  `servizioNome` varchar(255),
  `descrizione_servizio` text,
  `prezzo` currency
);

CREATE TABLE `appuntamenti` (
  `appuntamentoID` int PRIMARY KEY AUTO_INCREMENT,
  `clienteID` int,
  `appuntamento_Data_tempo` datetime,
  `parruchiereID` int
);

CREATE TABLE `appuntamento_details` (
  `appuntamentoDetailID` int PRIMARY KEY AUTO_INCREMENT,
  `appuntamentoID` int,
  `servizioID` int,
  `clienteID` int
);

CREATE TABLE `parrucchiere` (
  `parrucchiereID` int PRIMARY KEY AUTO_INCREMENT,
  `nome` varchar(255),
  `cognome` varchar(255),
  `Email` varchar(255),
  `numtelefono` varchar(255)
);

ALTER TABLE `appuntamenti` ADD FOREIGN KEY (`clienteID`) REFERENCES `clienti` (`clienteID`);

ALTER TABLE `appuntamenti` ADD FOREIGN KEY (`parruchiereID`) REFERENCES `parrucchiere` (`parrucchiereID`);

ALTER TABLE `appuntamento_details` ADD FOREIGN KEY (`appuntamentoID`) REFERENCES `appuntamenti` (`appuntamentoID`);

ALTER TABLE `appuntamento_details` ADD FOREIGN KEY (`servizioID`) REFERENCES `servizio` (`servizioID`);

ALTER TABLE `appuntamento_details` ADD FOREIGN KEY (`clienteID`) REFERENCES `clienti` (`clienteID`);
