CREATE TABLE [dbo].[Schedules]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[Title] NVARCHAR(100) NULL,
	[Details] NVARCHAR(MAX) NULL,
	[StartsAt] DATETIME NOT NULL,
	[EndsAt] DATETIME NOT NULL,
	[ModuleId] INT NOT NULL,
	CONSTRAINT [FK_Schedules_Module] FOREIGN KEY ([ModuleId]) REFERENCES [Modules]([Id])
)
