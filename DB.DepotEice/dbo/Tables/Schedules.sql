CREATE TABLE [dbo].[Schedules]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[Title] NVARCHAR(100) NULL,
	[Details] NVARCHAR(MAX) NULL,
	[StartTime] DATETIME NOT NULL,
	[EndTime] DATETIME NOT NULL,
	[ModuleId] INT NOT NULL,
	CONSTRAINT [FK_Schedules_Module] FOREIGN KEY ([ModuleId]) REFERENCES [Modules]([Id])
)
