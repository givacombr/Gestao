/*USE master
GO

DROP DATABASE Gestao
GO

CREATE DATABASE Gestao
GO

USE Gestao
GO*/

CREATE TABLE Usuario(
IdUsuario INT IDENTITY (1,1) NOT NULL,
Nome VARCHAR (100) NOT NULL,
NomeUsuario VARCHAR (100) NOT NULL,
CPF VARCHAR (15) NOT NULL,
Email VARCHAR (100) NOT NULL,
Senha VARCHAR (50) NOT NULL,
Ativo Bit NOT NULL
)
GO
CREATE TABLE Permissao(
IdDescricao INT IDENTITY (1,1) NOT NULL,
Descricao VARCHAR (100) NOT NULL
)
GO
CREATE TABLE GrupoUsuario(
IdGrupoUsuario INT IDENTITY (1,1) NOT NULL,
NomeGrupo VARCHAR (100) NOT NULL,
)
GO
CREATE TABLE UsuarioGrupoUsuario(
Cod_Usuario INT NOT NULL,
Cod_GrupoUsuario INT NOT NULL,
)
GO
CREATE TABLE PermissaoGrupoUsuario(
Cod_Descricao INT NOT NULL,
Cod_GrupoUsuario INT NOT NULL,
)
GO

select * from Usuario
select * from GrupoUsuario
select * from Permissao

DROP PROCEDURE SP_BuscarUsuarioPorNome

CREATE PROCEDURE SP_BuscarUsuarioPorNome
	@Nome varchar(150)
AS
BEGIN
	SELECT * FROM Usuario WHERE Nome LIKE '%%'
END
GO

EXEC SP_BuscarUsuarioPorNome "%"