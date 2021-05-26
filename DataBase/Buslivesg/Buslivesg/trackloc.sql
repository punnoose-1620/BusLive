CREATE TABLE [dbo].[trackloc]
(
	[Number] INT NOT NULL PRIMARY KEY DEFAULT 00, 
    [Password] VARCHAR(50) NOT NULL DEFAULT 'temp', 
    [Latitude] FLOAT NOT NULL DEFAULT 9.510080, 
    [Longitude] FLOAT NOT NULL DEFAULT 76.551458, 
    [Time] DATETIME NOT NULL DEFAULT sysdatetime()
)
