CREATE PROCEDURE [dbo].[spAddUserToModule]
	@userId UNIQUEIDENTIFIER,
	@moduleId INT
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO [dbo].[UsersModules]
	(
		UserId,
		ModuleId
	)
	VALUES
	(
		@userId,
		@moduleId
	);
END