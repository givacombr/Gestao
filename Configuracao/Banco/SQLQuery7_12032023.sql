  declare @Id_Usuario int = 1

  select GrupoUsuario.IdGrupoUsuario, GrupoUsuario.NomeGrupo from GrupoUsuario
  inner join UsuarioGrupoUsuario on GrupoUsuario.IdGrupoUsuario = UsuarioGrupoUsuario.Id_GrupoUsuario
  where Id_Usuario = @Id_Usuario

  declare @IDGrupoUsuario int = 1

  select Permissao.IdDescricao, Permissao.Descricao from Permissao
  inner join PermissaoGrupoUsuario on Permissao.IdDescricao = PermissaoGrupoUsuario.IdGrupoUsuario
  where IdGrupoUsuario = @IDGrupoUsuario

  select * from Permissao
  select * from PermissaoGrupoUsuario