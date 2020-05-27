CREATE PROCEDURE [dbo].[spGetAllAnimals]

AS
BEGIN
	SELECT Animal.Id
	,Animal.AnimalName
	,Animal.DateOfBirth
	,Animal_x_Person.PersonId
	from Animal
	left join Animal_x_Person on 
	Animal.Id = Animal_x_Person.AnimalId

END