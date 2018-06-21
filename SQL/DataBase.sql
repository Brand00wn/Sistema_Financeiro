CREATE DATABASE financeiro;

USE financeiro;

CREATE TABLE Tipo(
idTipo int NOT NULL PRIMARY KEY IDENTITY(1,1),
Tipo varchar(100) NOT NULL
);

CREATE TABLE Curso(
idCurso int NOT NULL PRIMARY KEY IDENTITY(1,1),
NomeCurso varchar(145) NOT NULL,
Tipo_idTipo int FOREIGN KEY REFERENCES Tipo(idTipo)
);

CREATE TABLE Mensalidade(
idMensalidade int NOT NULL PRIMARY KEY IDENTITY(1,1),
ValorMensalidade int NOT NULL,
DataVencimento date NOT NULL,
JurosAoDia int NOT NULL,
PercentualBolsa int NOT NULL,
Curso_idCurso int FOREIGN KEY REFERENCES Curso(idCurso)
);