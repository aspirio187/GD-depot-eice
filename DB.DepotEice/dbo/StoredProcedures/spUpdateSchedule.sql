CREATE PROCEDURE [dbo].[spUpdateSchedule]
	@id INT,
	@title NVARCHAR(100),
	@details NVARCHAR(MAX)
AS
	UPDATE
		[dbo].[Schedules]
	SET
		[Title] = @title,
		[Details] = @details
	WHERE
		[Id] = @id
GO
