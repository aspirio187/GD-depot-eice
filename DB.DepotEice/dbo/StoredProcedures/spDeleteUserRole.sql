CREATE PROCEDURE [dbo].[spDeleteUserRole]
	@userId UNIQUEIDENTIFIER,
	@roleId UNIQUEIDENTIFIER
AS
	DELETE FROM [dbo].[UsersRoles]
	WHERE ([UserId] = @userId) AND ([RoleId] = @roleId)
GO
