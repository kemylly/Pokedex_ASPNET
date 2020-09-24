
CREATE DATABASE BD_Pokemon;
GO
USE BD_Pokemon;

CREATE TABLE TBPokemons(
	Id INT IDENTITY PRIMARY KEY NOT NULL,
	Nome VARCHAR(30) NOT NULL UNIQUE,
	Tipo VARCHAR (20) NOT NULL,
    Descricao VARCHAR(100) NOT NULL
);
SELECT * FROM TBPokemons;

INSERT INTO TBPokemons(Nome, Tipo, Descricao)
	VALUES ('TesteNome', 'TesteTipo', 'TesteDescricao');