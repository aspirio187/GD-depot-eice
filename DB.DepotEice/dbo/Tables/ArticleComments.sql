CREATE TABLE [dbo].[ArticleComments]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[Note] INT NOT NULL,
	[Review] NVARCHAR(500) NOT NULL,
	[CreatedAt] DATETIME NOT NULL,
	[UpdatedAt] DATETIME NOT NULL,
	[ArticleId] INT NOT NULL,
	[UserId] UNIQUEIDENTIFIER NOT NULL,
	CONSTRAINT [FK_ArticleComments_Article] FOREIGN KEY ([ArticleId]) REFERENCES [Articles]([Id]),
	CONSTRAINT [FK_ArticleComments_User] FOREIGN KEY ([UserId]) REFERENCES [Users]([Id])
)
