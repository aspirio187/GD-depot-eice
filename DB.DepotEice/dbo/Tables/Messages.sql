﻿CREATE TABLE [dbo].[Messages]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[Body] NVARCHAR(1000) NOT NULL,
	[SentAt] DATETIME NOT NULL,
	[UserFromId] NVARCHAR(36) NOT NULL,
	[UserToId] NVARCHAR(36) NOT NULL,
	CONSTRAINT [FK_Messages_UserFrom] FOREIGN KEY ([UserFromId]) REFERENCES [Users]([Id]),
	CONSTRAINT [FK_Messages_UserTo] FOREIGN KEY ([UserToId]) REFERENCES [Users]([Id]),
)