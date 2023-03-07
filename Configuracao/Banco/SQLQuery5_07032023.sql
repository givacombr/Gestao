select * from Usuario
select * from GrupoUsuario
select * from Permissao

insert into GrupoUsuario(IdGrupoUsuario, NomeGrupo) 
values 
(1,'Financeiro'),
(2,'Administrativo'),
(3,'Logistico'),
(4,'Recursos Humano')

insert into Permissao(IdDescricao, Descricao) values 
(1,'Cadastrar'),
(2,'Alterar'),
(3,'Excluir')