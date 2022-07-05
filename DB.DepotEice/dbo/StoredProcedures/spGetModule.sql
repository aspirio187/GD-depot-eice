CREATE PROCEDURE [dbo].[spGetModule]
	@id INT
AS
	SELECT *
	FROM [Modules]
	WHERE [Modules].[Id] = @id
GO;
