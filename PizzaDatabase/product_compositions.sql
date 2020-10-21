CREATE TABLE [dbo].[product_compositions]
(
	[CompositionId] INT NOT NULL , 
    [ProductId] INT NOT NULL, 
    [ProductComposition] NCHAR(500) NULL, 
    PRIMARY KEY ([CompositionId]),
    FOREIGN KEY ([ProductId]) REFERENCES dbo.products_table([ProductId])
)
