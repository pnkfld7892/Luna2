CREATE PROCEDURE [dbo].[spGetAnimalById]
	@Id int
AS
BEGIN
	SELECT Animal.Id
	,Animal.AnimalTypeId
	,Animal.AnimalName
	,Animal.DateOfBirth
	from Animal
	where animal.Id = @id

END