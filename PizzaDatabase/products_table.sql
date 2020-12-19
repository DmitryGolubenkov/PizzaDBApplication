CREATE TABLE [dbo].[products_table]
(
	[ProductId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ProductName] NVARCHAR(80) NOT NULL, 
    [ProductPrice] INT NOT NULL, 
    [ProductDescription] NVARCHAR(500) NULL, 
    [ProductMarks] NVARCHAR(100) NULL

)