CREATE PROCEDURE [dbo].[spAddUserToRole]
	@userId UNIQUEIDENTIFIER,
	@roleId UNIQUEIDENTIFIER
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO [dbo].[UsersRoles]
	(
		UserId,
		RoleId
	)
	VALUES
	(
		@userId,
		@roleId
	);
END