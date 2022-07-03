﻿CREATE TABLE [dbo].[UsersTokens]
(
	[Id] NVARCHAR(36) NOT NULL PRIMARY KEY,
	[Type] NVARCHAR(100) NOT NULL,
	[Value] NVARCHAR(MAX) NOT NULL,
	[DeliveryDate] DATETIME NOT NULL,
	[ExpirationDate] DATETIME NOT NULL,
	[UserId] NVARCHAR(36) NOT NULL,
	CONSTRAINT [FK_UsersTokens_User] FOREIGN KEY ([UserId]) REFERENCES [Users]([Id])
)