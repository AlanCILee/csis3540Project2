CREATE TABLE [dbo].[Orders]
(
	[orderId] INT NOT NULL PRIMARY KEY, 
    [email] NVARCHAR(50) NULL CONSTRAINT [FK_customerId_to_orders] FOREIGN KEY([email])REFERENCES [Customers]([email]), 
    [productId] INT NULL CONSTRAINT [FK_productId_to_orders] FOREIGN KEY([productId])REFERENCES [Products]([productId]), 
    [quantity] INT NULL, 
    [delivered] INT NULL, 
    [orderDate] NVARCHAR(50) NULL
)
