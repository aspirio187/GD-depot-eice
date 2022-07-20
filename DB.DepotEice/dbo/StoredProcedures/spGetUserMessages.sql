CREATE PROCEDURE [dbo].[spUserMessages]
	@userId UNIQUEIDENTIFIER
AS
	SELECT *
	FROM [Messages]
	WHERE (SenderId = @userId) OR ([ReceiverId]= @userId)
GO