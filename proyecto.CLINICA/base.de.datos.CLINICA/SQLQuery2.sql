/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP 1000 [id_doctores]
      ,[nombres]
      ,[apellidos]
      ,[especialidad]
      ,[numero_credencial]
      ,[hospital_trabajo]
  FROM [CLINICA].[dbo].[DOCTORES]