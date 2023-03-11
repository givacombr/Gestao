select * from Permissao
select * from PermissaoGrupoUsuario
select * from GrupoUsuario

/*select * from Usuario
select * from GrupoUsuario
select * from UsuarioGrupoUsuario*/

INSERT INTO PermissaoGrupoUsuario VALUES (1)

DECLARE @IDGrupoUsuario int = 1

SELECT Permissao.IDDescricao, Permissao.DESCRICAO FROM Permissao 
INNER JOIN PermissaoGrupoUsuario ON Permissao.IDDescricao = PermissaoGrupoUsuario.IDGrupoUsuario
WHERE IDGrupoUsuario = @IDGrupoUsuario



/*DECLARE @Id_Usuario int = 1

SELECT GrupoUsuario.IDGrupoUsuario, GrupoUsuario.NomeGrupo FROM GrupoUsuario 
INNER JOIN UsuarioGrupoUsuario ON GrupoUsuario.IDGrupoUsuario = UsuarioGrupoUsuario.Id_GrupoUsuario
WHERE Id_Usuario = @Id_Usuario*/
