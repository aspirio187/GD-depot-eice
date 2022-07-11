CREATE PROCEDURE [dbo].[spCreateArticle]
	@title NVARCHAR(100),
	@body NVARCHAR(MAX),
	@pinned BIT,
	@userId UNIQUEIDENTIFIER
AS
BEGIN
	SET NOCOUNT ON;
	
	INSERT INTO [dbo].[Articles]
	(
		Title,
		Body,
		Pinned,
		UserId
	)
	VALUES
	(
		@title,
		@body,
		@pinned,
		@userId
	);

	SELECT SCOPE_IDENTITY();
END
