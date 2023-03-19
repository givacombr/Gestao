
insert into Usuario(Nome, NomeUsuario, CPF, Email, Senha, Ativo) values
('Gilson da Silva','silvag','023.145.258-00','silvag@globo.com','1472583690',1),
('Wellington Ferreira','ferreiraw','320.145.258-00','ferreiraw@globo.com','1472583690',1),
('Francilene Moreira','moreiraf','320.145.258-03','moreiraf@globo.com','1472583690',1),
('Marta Alc�ntara','alcantaram','625.145.335-00','alcantaram@globo.com','1472583690',1),
('Givanildo da Silveira','silveirag','625.145.258-68','silveirag@terra.com.br','1472583690',1),
('Paulo Vieira','vieirap','625.145.258-68','vieirap@terra.com.br','1472583690',1),
('Jos� Cleuton','cleutonj','625.145.258-68','cleutonj@uol.com.br','1472583690',1),
('Usuario de Teste','testando','625.145.258-68','teste@uol.com.br','1472583690',1)

insert into GrupoUsuario(NomeGrupo) values 
('Auxiliar'),
('Assistente'),
('Analista'),
('Supervisor'),
('Gerente'),
('Presidente'),
('Diretor Executivo'),
('Teste')

insert into Permissao(IdDescricao, Descricao) values 
(1,'Cadastrar usu�rio'),
(2,'Alterar usu�rio'),
(3,'Excluir usu�rio'),
(4,'Visualizar usu�rio'),
(5,'Cadastrar grupo de usu�rio'),
(6,'Alterar grupo de usu�rio'),
(7,'Excluir grupo de usu�rio'),
(8,'Visualizar grupo de usu�rio'),
(9,'Adicionar permiss�o a um grupo de usu�rio'),
(10,'Adicionar grupo de usu�rio a um usu�rio')

=================================
select * from Usuario
select * from GrupoUsuario
select * from Permissao
select * from PermissaoGrupoUsuario
select * from UsuarioGrupoUsuario

insert into PermissaoGrupoUsuario(Id_Descricao, Id_GrupoUsuario) values (2,7)
insert into PermissaoGrupoUsuario(Id_Descricao, Id_GrupoUsuario) values (3,7)
insert into PermissaoGrupoUsuario(Id_Descricao, Id_GrupoUsuario) values (4,7)
insert into PermissaoGrupoUsuario(Id_Descricao, Id_GrupoUsuario) values (6,7)
insert into PermissaoGrupoUsuario(Id_Descricao, Id_GrupoUsuario) values (7,7)
insert into PermissaoGrupoUsuario(Id_Descricao, Id_GrupoUsuario) values (8,7)
insert into PermissaoGrupoUsuario(Id_Descricao, Id_GrupoUsuario) values (9,7)
insert into PermissaoGrupoUsuario(Id_Descricao, Id_GrupoUsuario) values (10,7)

insert into UsuarioGrupoUsuario(Id_Usuario, Id_GrupoUsuario) values (2,7)
