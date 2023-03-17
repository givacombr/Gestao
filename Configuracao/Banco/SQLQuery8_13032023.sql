select * from Permissao
select * from GrupoUsuario
select * from PermissaoGrupoUsuario

/*select * from Usuario
select * from GrupoUsuario
select * from UsuarioGrupoUsuario*/

INSERT INTO PermissaoGrupoUsuario VALUES (1,1)
INSERT INTO PermissaoGrupoUsuario VALUES (2,1)
INSERT INTO PermissaoGrupoUsuario VALUES (1,2)
INSERT INTO PermissaoGrupoUsuario VALUES (2,2)
INSERT INTO PermissaoGrupoUsuario VALUES (3,2)

DECLARE @IDGrupoUsuario int = 1

SELECT Permissao.IDDescricao, Permissao.DESCRICAO FROM Permissao 
INNER JOIN PermissaoGrupoUsuario ON Permissao.IDDescricao = PermissaoGrupoUsuario.IDGrupoUsuario
WHERE IDGrupoUsuario = @IDGrupoUsuario



/*DECLARE @Id_Usuario int = 1

SELECT GrupoUsuario.IDGrupoUsuario, GrupoUsuario.NomeGrupo FROM GrupoUsuario 
INNER JOIN UsuarioGrupoUsuario ON GrupoUsuario.IDGrupoUsuario = UsuarioGrupoUsuario.Id_GrupoUsuario
WHERE Id_Usuario = @Id_Usuario*/

SELECT IDGrupoUsuario, NomeGrupo FROM GrupoUsuario
DECLARE @X int = 4

DECLARE @Id_Usuario int = 1
DECLARE @Id_GrupoUsuario INT = 1
select 1 AS Retorno from  UsuarioGrupoUsuario where Id_Usuario = @Id_Usuario and Id_GrupoUsuario = @Id_GrupoUsuario



As tabelas tem algum relacionamento entre si? Se tiver user um inner join:

select Id_Usuario, Id_GrupoUsuario from Usuario inner join GrupoUsuario on Usuario.IDUsuario =  GrupoUsuario.IDGrupoUsuario

Se não faz assim:

select  Id_Usuario, Id_GrupoUsuario from  Usuario, GrupoUsuario
