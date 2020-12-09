CREATE TABLE [dbo].[partner_products]
(
	[PartnerProductId] INT NOT NULL PRIMARY KEY IDENTITY,
	[ProductId] INT NOT NULL,
	[ProductPartnerPrice] FLOAT NOT NULL, 
    [ProductCount] INT NOT NULL, 
    FOREIGN KEY ([ProductId]) REFERENCES dbo.products_table([ProductId])
)
