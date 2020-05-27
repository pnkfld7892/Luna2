CREATE PROCEDURE [dbo].[spGetAllPersons]

AS
BEGIN
	SELECT 
	Person.Id
	,Person.FirstName
	,Person.LastName
	,Person.MiddleInitial
	from Person
END