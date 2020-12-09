using System.Collections.Generic;
using System.Threading.Tasks;
using PizzaDataLibrary.Models;

namespace PizzaDataLibrary.BusinessLogic
{
    public interface IClientData
    {
        Task<List<ClientModel>> GetClientsListTask();
        Task<int> AddClient(ClientModel client);
        public Task UpdateClient(ClientModel client);
        Task RemoveClient(ClientModel client);
    }
}