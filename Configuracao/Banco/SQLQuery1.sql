/*USE master
GO

DROP DATABASE Gestao
GO

CREATE DATABASE Gestao
GO

USE Gestao
GO
*/

CREATE TABLE Usuario
(
IDUsuario INT PRIMARY KEY IDENTITY(1,1),
NOME VARCHAR(150),
NOMEUSUARIO VARCHAR(150),
CPF VARCHAR(15),
EMAIL VARCHAR(150),
SENHA VARCHAR(50),
ATIVO BIT
);
GO

CREATE TABLE Permissao
(
IDDescricao INT PRIMARY KEY,
DESCRICAO VARCHAR(250)
);
GO

CREATE TABLE GrupoUsuario
(
IDGrupoUsuario INT PRIMARY KEY,
NOMEGRUPO VARCHAR(150)
);
GO

CREATE TABLE PermissaoGrupoUsuario
(
IDDescricao INT PRIMARY KEY,
IDGrupoUsuario INT PRIMARY KEY
);
GO

ALTER TABLE PermissaoGrupoUsuario ADD CONSTRAINT FK_PermissaoGrupoUsuario FOREIGN KEY(IDDescricao) REFERENCES Permissao(IDDescricao);

ALTER TABLE PermissaoGrupoUsuario ADD CONSTRAINT FK_PermissaoGrupoUsuario FOREIGN KEY(IDGrupoUsuario) REFERENCES GrupoUsuario(IDGrupoUsuario); 

INSERT INTO Usuario(1,'pedro','pedro de carvalho','123.456.789-00','pedro@hotmail.com','456acb123',1),
INSERT INTO Permissao(1,'nao esquecer'),
INSERT INTO GrupoUsuario(1,'Advogados')

select * from Usuario
select * from Permissao
select * from GrupoUsuario
