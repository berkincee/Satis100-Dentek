DATABASEİN OLUŞABİLMESİ İÇİN GEREKLİ QUERYLER AŞAĞIDADIR.

CREATE TABLE Customer (
    Id INT IDENTITY(1, 1) NOT NULL PRIMARY KEY,
    Name NVARCHAR(MAX) NOT NULL,
    Address VARCHAR(MAX) NULL,
    PhoneNumber NVARCHAR(MAX) NULL
);

CREATE TABLE Make (
    Id INT IDENTITY(1, 1) NOT NULL PRIMARY KEY,
    Name NVARCHAR(MAX) NOT NULL
);

CREATE TABLE Model (
    Id INT IDENTITY(1, 1) NOT NULL PRIMARY KEY,
    MakeId INT FOREIGN KEY REFERENCES Make(Id) NOT NULL,
    Name NVARCHAR(MAX) NOT NULL,
	Cost INT	NOT NULL
);

CREATE TABLE Stock (
    Id INT IDENTITY(1, 1) NOT NULL PRIMARY KEY,
    ModelId INT FOREIGN KEY REFERENCES Model(Id) NOT NULL,
    Quantity INT NOT NULL
);


CREATE TABLE Facture (
    Id INT IDENTITY(1, 1) NOT NULL PRIMARY KEY,
    TotalCost INT NOT NULL,
	CustomerId INT FOREIGN KEY REFERENCES Customer(Id),

);


CREATE TABLE FactureModel (
    FactureId INT FOREIGN KEY REFERENCES Facture(Id),
    ModelId INT FOREIGN KEY REFERENCES Model(Id),
    PRIMARY KEY (FactureId, ModelId)
);

INSERT INTO Make (Name) VALUES ('Peugeot');
INSERT INTO Make (Name) VALUES ('Citroen');
INSERT INTO Make (Name) VALUES ('Renault');

INSERT INTO Model (MakeId, Name, Cost) VALUES ((SELECT Id FROM Make WHERE Name = 'Peugeot'), '208', 100000);
INSERT INTO Model (MakeId, Name, Cost) VALUES ((SELECT Id FROM Make WHERE Name = 'Peugeot'), '308', 150000);
INSERT INTO Model (MakeId, Name, Cost) VALUES ((SELECT Id FROM Make WHERE Name = 'Peugeot'), '408', 200000);


INSERT INTO Model (MakeId, Name, Cost) VALUES ((SELECT Id FROM Make WHERE Name = 'Citroen'), 'C3', 120000);
INSERT INTO Model (MakeId, Name, Cost) VALUES ((SELECT Id FROM Make WHERE Name = 'Citroen'), 'C4', 180000);
INSERT INTO Model (MakeId, Name, Cost) VALUES ((SELECT Id FROM Make WHERE Name = 'Citroen'), 'C5', 220000);


INSERT INTO Model (MakeId, Name, Cost) VALUES ((SELECT Id FROM Make WHERE Name = 'Renault'), 'Twingo', 110000);
INSERT INTO Model (MakeId, Name, Cost) VALUES ((SELECT Id FROM Make WHERE Name = 'Renault'), 'Clio', 160000);
INSERT INTO Model (MakeId, Name, Cost) VALUES ((SELECT Id FROM Make WHERE Name = 'Renault'), 'Megan', 190000);


INSERT INTO Customer (Name, Address, PhoneNumber) VALUES ('ABC AÞ', '1421 Sokak', '464-1234');
INSERT INTO Customer (Name, Address, PhoneNumber) VALUES ('XYZ AÞ', '1388 Sokak', '464-5678');
INSERT INTO Customer (Name, Address, PhoneNumber) VALUES ('LMN AÞ', '1381 Sokak', '464-9012');

ALTER TABLE Facture
ADD [Date] DATE not null;
