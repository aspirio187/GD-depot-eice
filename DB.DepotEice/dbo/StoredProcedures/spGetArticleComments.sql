CREATE PROCEDURE [dbo].[spGetArticleComments]
	@articleId int = 0
AS
	SELECT *
	FROM [Appointments]
	WHERE [Appointments].[Id] = @articleId
GO;
