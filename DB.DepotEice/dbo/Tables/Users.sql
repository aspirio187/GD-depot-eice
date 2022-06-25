CREATE TABLE [dbo].[Users]
(
	[Id] NVARCHAR(36) NOT NULL PRIMARY KEY, 
    [Email] NVARCHAR(255) NOT NULL, 
    [NormalizedEmail] NVARCHAR(255) NOT NULL,
    [PasswordHash] BINARY(64) NOT NULL, 
    [Salt] UNIQUEIDENTIFIER NOT NULL,
    [FirstName] NVARCHAR(50) NOT NULL, 
    [Lastname] NVARCHAR(100) NOT NULL,
    [ProfilePicture] NVARCHAR(255) NOT NULL, 
    [BirthDate] DATE NOT NULL, 
    [ConcurrencyStamp] UNIQUEIDENTIFIER NOT NULL, 
    [SecurityStamp] UNIQUEIDENTIFIER NOT NULL, 
    [CreatedAt] DATETIME NOT NULL, 
    [UpdatedAt] DATETIME NULL, 
    [DeletedAt] DATETIME NULL
)
