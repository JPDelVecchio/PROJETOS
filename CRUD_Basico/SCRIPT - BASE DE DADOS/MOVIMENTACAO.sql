
--CREATE DATABASE MOVIMENTACAO;

--USE MOVIMENTACAO;

--CREATE TABLE CLIFOR(
--IDCLIFOR  INT PRIMARY KEY IDENTITY(1,1),
--NOME VARCHAR(200) NOT NULL,
--ENDERECO VARCHAR(200) NOT NULL,
--TELEFONE VARCHAR(15),
--CNPJ VARCHAR(30) UNIQUE NOT NULL
--)

--CREATE TABLE PRODUTO(
--IDPRODUTO INT PRIMARY KEY IDENTITY,
--NOME VARCHAR(200) NOT NULL UNIQUE,
--DESCRICAO VARCHAR(MAX),
--UNIDADE VARCHAR(5) NOT NULL
--)
--INSERT INTO CLIFOR (NOME, ENDERECO, CNPJ) VALUES ('Dona Cida e Seu Z�', 'R: das Ofelias, 131 Atibaia - SP', 'XXX.XXX.XXX-XX');
--SELECT * FROM CLIFOR  

--INSERT INTO PRODUTO (NOME, UNIDADE) VALUES ('FANTA UVA 350 ML', 'LT');
--INSERT INTO PRODUTO (NOME, UNIDADE) VALUES ('FANTA LARANJA 350 ML', 'LT');
--INSERT INTO PRODUTO (NOME, UNIDADE) VALUES ('COCA COLA 350 ML', 'LT');

--SELECT * FROM PRODUTO


--CREATE TABLE MOVIMENTO(
--IDMOVIMENTO INT IDENTITY PRIMARY KEY,
--IDFORNECEDOR INT NOT NULL,
--IDCLIENTE INT NOT NULL,
--HISTORICO VARCHAR(250),
--VALORDOCUMENTO FLOAT,
--DATAMOVIMENTO DATETIME NOT NULL,
--CONSTRAINT FK_FORNECEDOR FOREIGN KEY (IDFORNECEDOR) REFERENCES  CLIFOR (IDCLIFOR),
--CONSTRAINT FK_CLIENTE FOREIGN KEY (IDCLIENTE) REFERENCES  CLIFOR (IDCLIFOR)
--/* 
--POSSIVELMENTE N�O SER� NECESS�RIO NESTES PRIMEIROS EXEMPLOS
----ON UPDATE CASCADE 
----ON DELETE CASCADE
--*/
--)

--CREATE TABLE ITEM(
--IDPRODUTO INT NOT NULL,
--IDMOVIMENTO INT NOT NULL,
--QUANTIDADE FLOAT
--CONSTRAINT FK_PRODUTO FOREIGN KEY (IDPRODUTO) REFERENCES PRODUTO (IDPRODUTO),
--CONSTRAINT FK_MOVIMENTO FOREIGN KEY (IDMOVIMENTO) REFERENCES MOVIMENTO (IDMOVIMENTO) 
--)