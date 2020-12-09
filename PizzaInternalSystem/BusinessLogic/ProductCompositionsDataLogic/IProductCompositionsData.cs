using System.Collections.Generic;
using System.Threading.Tasks;
using PizzaDataLibrary.Models;

namespace PizzaDataLibrary.BusinessLogic
{
    public interface IProductCompositionsData
    {
        Task<List<ProductCompositionsModel>> GetCompositionsListTask();
        Task<int> Add(ProductCompositionsModel model);
        public Task Update(ProductCompositionsModel model);
        Task Remove(ProductCompositionsModel model);
    }
}