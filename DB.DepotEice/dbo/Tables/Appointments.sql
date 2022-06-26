CREATE TABLE [dbo].[Appointments]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[StartAt] DATETIME NOT NULL,
	[EndAt] DATETIME NOT NULL,
	[Accepted] BIT NOT NULL,
	[UserId] NVARCHAR(36) NOT NULL,
	CONSTRAINT [FK_Appointments_User] FOREIGN KEY ([UserId]) REFERENCES [Users]([Id])
)
