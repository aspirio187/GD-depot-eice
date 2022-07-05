CREATE PROCEDURE [dbo].[spUpdateModule]
	@id INT NOT NULL,
	@name NVARCHAR(255) NOT NULL,
	@description NVARCHAR(1000) NOT NULL
AS
	UPDATE [Modules]
	SET [Name] = @name, [Description] = @description
	WHERE [Modules].[Id] = @id
GO;
