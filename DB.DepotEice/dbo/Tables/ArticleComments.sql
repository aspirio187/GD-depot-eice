CREATE TABLE [dbo].[ArticleComments]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[Note] INT NOT NULL,
	[Review] NVARCHAR(500) NOT NULL,
	[CreatedAt] DATETIME NOT NULL,
	[UpdatedAt] DATETIME NOT NULL,
	[ArticleId] INT NOT NULL,
	[UserId] NVARCHAR(36) NOT NULL,
	CONSTRAINT [FK_ArticleComments_Article] FOREIGN KEY ([ArticleId]) REFERENCES [Articles]([Id]),
	CONSTRAINT [FK_ArticleComments_User] FOREIGN KEY ([UserId]) REFERENCES [Users]([Id])
)
