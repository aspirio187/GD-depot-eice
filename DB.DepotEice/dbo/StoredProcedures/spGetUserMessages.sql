CREATE PROCEDURE [dbo].[spUserMessages]
	@userId UNIQUEIDENTIFIER
AS
	SELECT *
	FROM [Messages]
	WHERE ([UserToId] = @userId) OR ([UserFromId] = @userId)
GO