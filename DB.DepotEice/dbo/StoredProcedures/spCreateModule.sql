CREATE PROCEDURE [dbo].[spCreateModule]
	@name NVARCHAR(255),
	@description NVARCHAR(1000)
AS
	INSERT INTO [Modules]([Name], [Description])
	VALUES (@name, @description);

	SELECT SCOPE_IDENTITY();
GO;
