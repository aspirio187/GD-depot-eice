﻿CREATE PROCEDURE [dbo].[spMessages_BetweenUsers]
	@RequestUserId INT,
	@TargetUserId INT
AS
BEGIN
	SELECT 
		[Id],
		IIF([SenderId] = @RequestUserId, @RequestUserId, @TargetUserId) as 'UserId',
		IIF([SenderId] = @RequestUserId, (SELECT [FirstName], [Lastname] FROM dbo.Users WHERE [Id] = @RequestUserId), (SELECT [FirstName], [Lastname] FROM dbo.Users WHERE [Id] = @TargetUserId)) as 'Username',
		[Content],
		[SentAt]
	FROM dbo.[Messages] 
	WHERE ([SenderId] = @RequestUserId AND [ReceiverId] = @TargetUserId) OR ([SenderId] = @TargetUserId AND [ReceiverId] = @RequestUserId) 
	ORDER BY [SentAt] DESC
END