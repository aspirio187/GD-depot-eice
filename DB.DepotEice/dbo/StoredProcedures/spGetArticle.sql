CREATE PROCEDURE [dbo].[spGetArticle]
	@articleId int
AS
	SELECT *
	FROM [Articles]
	WHERE [Articles].[Id] = @articleId
RETURN 0
