CREATE PROCEDURE [dbo].[spUpdateAppointment]
	@id INT,
	@startAt DATETIME,
	@endAt DATETIME,
	@accepted BIT
AS
	UPDATE [Appointments]
	SET [StartAt] = @startAt, [EndAt] = @endAt, [Accepted] = @accepted
	WHERE [Appointments].[Id] = @id
GO;
