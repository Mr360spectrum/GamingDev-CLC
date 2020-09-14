CREATE TABLE [dbo].[Table]
(
	[contact Id] INT NOT NULL PRIMARY KEY, 
    [name] NVARCHAR(MAX) NOT NULL, 
    [number] NVARCHAR(50) NOT NULL, 
    [email] NVARCHAR(50) NULL, 
    [address] NVARCHAR(MAX) NULL, 
    [fav food] NVARCHAR(MAX) NULL, 
    [birthday] DATE NULL, 
    [last call] DATETIME NULL, 
    [alt phone] NVARCHAR(50) NULL, 
    [company] NVARCHAR(MAX) NOT NULL 
)
