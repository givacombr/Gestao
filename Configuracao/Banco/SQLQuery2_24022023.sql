/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [IDUsuario]
      ,[NOME]
      ,[NOMEUSUARIO]
      ,[CPF]
      ,[EMAIL]
      ,[SENHA]
      ,[ATIVO]
  FROM [Gestao].[dbo].[Usuario]