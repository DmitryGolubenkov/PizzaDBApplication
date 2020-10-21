using System.Collections.Generic;
using System.Threading.Tasks;
using PizzaDataLibrary.DataAccess;
using PizzaDataLibrary.Models;

namespace PizzaDataLibrary.BusinessLogic
{
    public class ClientData : IClientData
    {
        private readonly ISqlDataAccess _db;
        public ClientData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<ClientModel>> GetClients()
        {
            string sql = "select * from table_clients";
            return _db.LoadData<ClientModel, dynamic>(sql, new { });
        }

    }
}