CREATE TABLE clienti (
  clienteID INT PRIMARY KEY IDENTITY(1,1),
  nome VARCHAR(255) NOT NULL,
  cognome VARCHAR(255) NOT NULL,
  Email VARCHAR(255) NOT NULL,
  numtelefono VARCHAR(255) NOT NULL
);

CREATE TABLE servizio (
  servizioID INT PRIMARY KEY IDENTITY(1,1),
  servizioNome VARCHAR(255) NOT NULL,
  descrizione_servizio TEXT NOT NULL,
  prezzo DECIMAL(10, 2) NOT NULL
);

CREATE TABLE appuntamenti (
  appuntamentoID INT PRIMARY KEY IDENTITY(1,1),
  clienteID INT NOT NULL,
  appuntamento_Data_tempo DATETIME NOT NULL,
  FOREIGN KEY (clienteID) REFERENCES clienti(clienteID)
);

CREATE TABLE appuntamento_details (
  appuntamentoDetailID INT PRIMARY KEY IDENTITY(1,1),
  appuntamentoID INT NOT NULL,
  servizioID INT NOT NULL,
  clienteID INT NOT NULL,
  prezzotot DECIMAL(10, 2) NOT NULL,
  FOREIGN KEY (appuntamentoID) REFERENCES appuntamenti(appuntamentoID),
  FOREIGN KEY (servizioID) REFERENCES servizio(servizioID),
  FOREIGN KEY (clienteID) REFERENCES clienti(clienteID)
);
