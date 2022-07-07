﻿CREATE TABLE [dbo].[Messages]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[Body] NVARCHAR(1000) NOT NULL,
	[SentAt] DATETIME NOT NULL,
	[UserFromId] UNIQUEIDENTIFIER NOT NULL,
	[UserToId] UNIQUEIDENTIFIER NOT NULL,
	CONSTRAINT [FK_Messages_UserFrom] FOREIGN KEY ([UserFromId]) REFERENCES [Users]([Id]),
	CONSTRAINT [FK_Messages_UserTo] FOREIGN KEY ([UserToId]) REFERENCES [Users]([Id]),
)
