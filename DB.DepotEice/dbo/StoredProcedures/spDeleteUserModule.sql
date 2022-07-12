CREATE PROCEDURE [dbo].[spDeleteUserModule]
	@userId UNIQUEIDENTIFIER,
	@moduleId INT
AS
	DELETE FROM [dbo].[UsersModules]
	WHERE ([UserId] = @userId) AND ([ModuleId] = @moduleId)
GO
