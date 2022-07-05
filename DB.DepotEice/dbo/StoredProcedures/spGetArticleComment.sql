CREATE PROCEDURE [dbo].[spGetArticleComment]
	@id INT NOT NULL
AS
	SELECT *
	FROM [Appointments]
	WHERE [Appointments].[Id] = @id
GO;
