﻿CREATE TABLE [dbo].[OpeningHours]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[OpenAt] DATETIME NOT NULL,
	[CloseAt] DATETIME NOT NULL
)