CREATE TABLE [dbo].[Animal]
(
	[Id] INT identity(100,1) NOT NULL PRIMARY KEY
	,[AnimalName] varchar(255) not null
	,[AnimalTypeId] int not null
	,[DateOfBirth] datetime2 not null
    ,CONSTRAINT [FK_Animal_ToAnimalType] FOREIGN KEY (AnimalTypeId) REFERENCES [AnimalType]([Id])
)
