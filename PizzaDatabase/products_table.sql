CREATE TABLE [dbo].[products_table]
(
	[ProductId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ProductName] NCHAR(50) NOT NULL, 
    [ProductPrice] INT NOT NULL, 
    [ProductDescription] NCHAR(500) NULL, 
    [ProductMarks] NCHAR(100) NULL

)