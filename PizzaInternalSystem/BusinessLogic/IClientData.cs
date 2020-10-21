using System.Collections.Generic;
using System.Threading.Tasks;
using PizzaDataLibrary.Models;

namespace PizzaDataLibrary.BusinessLogic
{
    public interface IClientData
    {
        Task<List<ClientModel>> GetClients();
    }
}