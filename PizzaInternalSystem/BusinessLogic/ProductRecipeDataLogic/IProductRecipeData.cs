using System.Collections.Generic;
using System.Threading.Tasks;
using PizzaDataLibrary.Models;

namespace PizzaDataLibrary.BusinessLogic
{
    public interface IProductRecipeData
    {
        Task<List<ProductRecipeModel>> GetRecipesListTask();
        Task<int> Add(ProductRecipeModel model);
        public Task Update(ProductRecipeModel model);
        Task Remove(ProductRecipeModel model);
    }
}