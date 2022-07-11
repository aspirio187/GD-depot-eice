CREATE PROCEDURE [dbo].[spCreateAppointment]
	@startsAt DATETIME,
	@endsAt DATETIME,
	@userId NVARCHAR(36)
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO [dbo].[Appointments]
	(
		[StartAt],
		[EndAt],
		[UserId]
	)
	VALUES 
	(
		@startsAt,
		@endsAt,
		@userId
	);

	SELECT SCOPE_IDENTITY();
END
