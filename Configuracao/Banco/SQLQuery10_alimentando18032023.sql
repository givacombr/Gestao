
insert into Usuario(Nome, NomeUsuario, CPF, Email, Senha, Ativo) values
('Gilson da Silva','silvag','023.145.258-00','silvag@globo.com','1472583690',1),
('Wellington Ferreira','ferreiraw','320.145.258-00','ferreiraw@globo.com','1472583690',1),
('Francilene Moreira','moreiraf','320.145.258-03','moreiraf@globo.com','1472583690',1),
('Marta Alcântara','alcantaram','625.145.335-00','alcantaram@globo.com','1472583690',1),
('Givanildo da Silveira','silveirag','625.145.258-68','silveirag@terra.com.br','1472583690',1),
('Paulo Vieira','vieirap','625.145.258-68','vieirap@terra.com.br','1472583690',1),
('José Cleuton','cleutonj','625.145.258-68','cleutonj@uol.com.br','1472583690',1),
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
(1,'Cadastrar usuário'),
(2,'Alterar usuário'),
(3,'Excluir usuário'),
(4,'Visualizar usuário'),
(5,'Cadastrar grupo de usuário'),
(6,'Alterar grupo de usuário'),
(7,'Excluir grupo de usuário'),
(8,'Visualizar grupo de usuário'),
(9,'Adicionar permissão a um grupo de usuário'),
(10,'Adicionar grupo de usuário a um usuário')

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
