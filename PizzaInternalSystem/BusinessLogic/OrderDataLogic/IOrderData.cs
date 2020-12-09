using System.Collections.Generic;
using System.Threading.Tasks;
using PizzaDataLibrary.Models;

namespace PizzaDataLibrary.BusinessLogic
{
    public interface IOrderData
    {
        Task<List<OrderModel>> GetOrdersListTask();
        Task<int> AddOrder(OrderModel model);
        public Task UpdateOrder(OrderModel model);
        Task RemoveOrder(OrderModel model);
    }
}