CREATE PROCEDURE [dbo].[spGetModules]
	@moduleId int
AS
	SELECT *
	FROM [Modules]
	WHERE [Modules].[Id] = @moduleId
GO;