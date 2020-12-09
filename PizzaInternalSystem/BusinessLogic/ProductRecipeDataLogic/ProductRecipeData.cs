using System.Collections.Generic;
using System.Threading.Tasks;
using PizzaDataLibrary.DataAccess;
using PizzaDataLibrary.Models;

namespace PizzaDataLibrary.BusinessLogic
{
    public class ProductRecipeData : IProductRecipeData
    {
        private readonly ISqlDataAccess _db;

        public ProductRecipeData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<ProductRecipeModel>> GetRecipesListTask()
        {
            string sql = "SELECT * FROM product_recipes";

            return _db.LoadData<ProductRecipeModel, dynamic>(sql, new { });
        }

        public Task<int> Add(ProductRecipeModel model)
        {
            string sql = @"insert into product_recipes (ProductId, ProductRecipe) 
values (@ProductId, @ProductRecipe); select scope_identity()";

            return _db.InsertDataIntoDatabase(sql, model);
        }

        public Task Update(ProductRecipeModel model)
        {
            string sql =
                @"UPDATE product_recipes SET ProductId=@ProductId, ProductRecipe=@ProductRecipe WHERE RecipeId=@RecipeId";

            return _db.ExecuteSQLQuery(sql, model);
        }

        public Task Remove(ProductRecipeModel model)
        {
            string sql =
                @"DELETE FROM product_recipes WHERE RecipeId=@RecipeId";

            return _db.ExecuteSQLQuery(sql, model);
        }
    }
}