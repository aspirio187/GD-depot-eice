CREATE PROCEDURE [dbo].[spCreateAppointment]
	@startsAt DATETIME,
	@endsAt DATETIME,
	@accepted BIT,
	@userId NVARCHAR(36)
AS
	INSERT INTO [Appointments]([StartAt], [EndAt], [Accepted], [UserId])
	VALUES (@startsAt, @endsAt, @accepted, @userId);

	SELECT SCOPE_IDENTITY();
GO;
