CREATE PROCEDURE [dbo].[spUserMessages]
	@userId NVARCHAR(36)
AS
	SELECT *
	FROM [Messages]
	WHERE [Messages].[UserToId] = @userId OR [Messages].[UserFromId] = @userId
GO;