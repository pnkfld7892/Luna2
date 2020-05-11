CREATE PROCEDURE [dbo].[spGetAllAnimals]

AS
BEGIN
	SELECT Animal.Id
	,Animal.AnimalName
	,Animal.DateOfBirth
	from Animal

END