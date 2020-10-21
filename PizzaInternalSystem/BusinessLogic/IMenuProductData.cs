using System.Collections.Generic;
using System.Threading.Tasks;
using PizzaDataLibrary.Models;

namespace PizzaDataLibrary.BusinessLogic
{
    public interface IMenuProductData
    {
        Task<List<MenuProductModel>> GetProductsList();
        Task AddProduct(MenuProductModel product);
        public Task UpdateProduct(MenuProductModel product);
        Task RemoveProduct(MenuProductModel product);
    }
}