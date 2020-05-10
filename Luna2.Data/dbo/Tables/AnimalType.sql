CREATE TABLE [dbo].[AnimalType]
(
	[Id] INT Identity (100,1) NOT NULL PRIMARY KEY
	,[Description] varchar(255) not null
	,[DateCreated] datetime2 not null
)