 /****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [IdUsuario]
      ,[Nome]
      ,[NomeUsuario]
      ,[CPF]
      ,[Email]
      ,[Senha]
      ,[Ativo]
  FROM [Gestao].[dbo].[Usuario]