/****** Script for SelectTopNRows command from SSMS  ******/
USE [TaskDatabase]
GO
DELETE FROM [TaskDatabase].[dbo].[Task]
GO
DBCC CHECKIDENT (Task, RESEED, 1)
GO
