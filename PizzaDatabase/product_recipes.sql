CREATE TABLE [dbo].[product_recipes]
(
	[RecipeId] INT NOT NULL , 
    [ProductId] INT NOT NULL, 
    [ProductRecipe] NCHAR(1500) NULL, 
    PRIMARY KEY ([RecipeId]),
    FOREIGN KEY ([ProductId]) REFERENCES dbo.products_table([ProductId])
)
