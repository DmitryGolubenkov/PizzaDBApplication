CREATE TABLE [dbo].[product_compositions]
(
	[CompositionId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ProductId] INT NOT NULL, 
    [ProductComposition] NVARCHAR(500) NOT NULL
)
