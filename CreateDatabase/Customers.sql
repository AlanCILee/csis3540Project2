CREATE TABLE [dbo].[Customers]
(
	[email] NVARCHAR(50) NOT NULL PRIMARY KEY, 
    [firstName] NVARCHAR(50) NULL, 
    [lastName] NVARCHAR(50) NULL, 
    [address] TEXT NULL, 
    [phone] NVARCHAR(50) NULL
)
