CREATE DATABASE Jogos;
Go

USE Jogos;
GO

CREATE TABLE TipoUsuario(
idTipoUsuario INT PRIMARY KEY IDENTITY,
NomeTipoUsuario VARCHAR(30) UNIQUE not null
);
GO

CREATE TABLE Usuario(
idUsuario INT PRIMARY KEY IDENTITY,
Email VARCHAR(30)UNIQUE not null,
Nome VARCHAR(30)not null,
Senha VARCHAR(20)not null,
idTipoUsuario INT FOREIGN KEY REFERENCES TipoUsuario(idTipoUsuario)not null
);
GO

CREATE TABLE Jogo(
idJogo INT PRIMARY KEY IDENTITY,
TituloJogo VARCHAR(40)NOT NULL,
Descricao text not null,
DataLan DATE NOT NULL,
Valor Decimal not null,
Caminho Varchar(300)
);
GO

SELECT * FROM Usuario

USE master;
DROP DATABASE Jogos;