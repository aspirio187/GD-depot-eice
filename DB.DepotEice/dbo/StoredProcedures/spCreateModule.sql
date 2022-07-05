CREATE PROCEDURE [dbo].[spCreateModule]
	@name NVARCHAR(255) NOT NULL,
	@description NVARCHAR(1000) NOT NULL
AS
	INSERT INTO [Modules]([Name], [Description])
	VALUES (@name, @description);

	SELECT SCOPE_IDENTITY();
GO;
