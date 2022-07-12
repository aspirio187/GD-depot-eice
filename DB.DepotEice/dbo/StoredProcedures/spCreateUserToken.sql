CREATE PROCEDURE [dbo].[spCreateUserToken]
	@type NVARCHAR(100),
	@value NVARCHAR(MAX),
	@expirationDate DATETIME2,
	@userId UNIQUEIDENTIFIER
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO [dbo].[UsersTokens]
	(
		[Type],
		[Value],
		[ExpirationDate],
		[UserId]
	)
	OUTPUT inserted.Id
	VALUES
	(
		@type,
		@value,
		@expirationDate,
		@userId
	);

END

