CREATE PROCEDURE [dbo].[spDeleteModule]
	@id INT NOT NULL
AS
	DELETE FROM [Modules]
	WHERE [Modules].[Id] = @id
GO;
