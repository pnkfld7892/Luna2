CREATE TABLE [dbo].[Animal_x_Person]
(
	[Id] INT identity(100,1) NOT NULL PRIMARY KEY
	,AnimalId int not null
	,PersonId int not null, 
    CONSTRAINT [FK_Animal_x_Person_ToAnimal] FOREIGN KEY (AnimalId) REFERENCES Animal(Id) 
    ,CONSTRAINT [FK_Animal_x_Person_ToPerson] FOREIGN KEY (PersonId) REFERENCES Person(Id)

)
