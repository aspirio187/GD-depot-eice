CREATE PROCEDURE [dbo].[spGetAppointment]
	@appointmentId int = 0
AS
	SELECT * 
	FROM [Appointments] 
	WHERE [Appointments].[Id] = @appointmentId
GO;
