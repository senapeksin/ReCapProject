﻿CREATE TABLE [dbo].[Car]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [BrandId] INT NULL, 
    [ColorId] INT NULL, 
    [ModelYear] NVARCHAR(50) NULL, 
    [DailyPrice] INT NULL, 
    [Description] NVARCHAR(50) NULL
)
