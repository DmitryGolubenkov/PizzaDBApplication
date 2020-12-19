CREATE TABLE [dbo].[product_recipes]
(
	[RecipeId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ProductId] INT NOT NULL, 
    [ProductRecipe] NVARCHAR(1500) NOT NULL, 
    FOREIGN KEY ([ProductId]) REFERENCES dbo.products_table([ProductId])
)
