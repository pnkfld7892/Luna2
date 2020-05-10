CREATE TABLE [dbo].[Person]
(
	[Id] INT IDENTITY(100,1) NOT NULL PRIMARY KEY
	,[FirstName] varchar(255) not null
	,[MiddleInitial] varchar(5) not null
	,[LastName] varchar(255) NOT NULL
	,[DateCreated] datetime2 not null
)
