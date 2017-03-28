CREATE TABLE [dbo].[Products]
(
	[productId] INT NOT NULL PRIMARY KEY, 
    [productName] NVARCHAR(50) NULL, 
    [unitPrice] INT NULL, 
    [categoryId] INT NULL CONSTRAINT [FK_categoryId_to_products] FOREIGN KEY([categoryId])REFERENCES [Categories]([categoryId]), 
    [quantityAvailable] INT NULL, 
    [primeCost] INT NULL
)
