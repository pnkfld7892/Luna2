CREATE PROCEDURE [dbo].[spGetAllAnimalPersons]
AS
BEGIN
	SELECT Animal_x_Person.AnimalId
	,Animal_x_Person.PersonId
	from dbo.Animal_x_Person
END