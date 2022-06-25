CREATE TABLE [dbo].[UsersRoles]
(
	[UserId] NVARCHAR(36) NOT NULL,
	[RoleId] NVARCHAR(36) NOT NULL,
	CONSTRAINT PK_UsersRoles PRIMARY KEY (UserId, RoleId),
    CONSTRAINT [FK_UsersRoles_User] FOREIGN KEY ([UserId]) REFERENCES [Users]([Id]),
	CONSTRAINT [FK_UsersRoles_Role] FOREIGN KEY ([RoleId]) REFERENCES [Roles]([Id])
)
