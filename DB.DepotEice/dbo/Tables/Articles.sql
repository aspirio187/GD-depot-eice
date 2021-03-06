CREATE TABLE [dbo].[Articles]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[Title] NVARCHAR(100) NOT NULL,
	[Body] TEXT NOT NULL,
	[CreatedAt] DATETIME2 NOT NULL DEFAULT GETDATE(),
	[UpdatedAt] DATETIME2 NULL,
	[Pinned] BIT NOT NULL,
	[UserId] UNIQUEIDENTIFIER NOT NULL,
	CONSTRAINT [FK_Articles_User] FOREIGN KEY ([UserId]) REFERENCES [Users]([Id])
)
