﻿CREATE FUNCTION [dbo].[fnHashPassword]
(
	@password NVARCHAR(25),
	@salt NVARCHAR
)
RETURNS BINARY(32)
AS
BEGIN
	RETURN HASBYTES('SHA2_256', CONCAT(@password, @salt))
END
