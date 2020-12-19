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

        public Task<List<ClientModel>> GetClientsListTask()
        {
            string sql = "select * from table_clients";
            return _db.LoadData<ClientModel, dynamic>(sql, new { });
        }


        public Task<int> AddClient(ClientModel client)
        {
            string sql = "insert into table_clients (Name, Address, PhoneNumber) values (@Name, @Address, @PhoneNumber); select scope_identity()";

            return _db.InsertDataIntoDatabase(sql, client);
        }

        public Task UpdateClient(ClientModel client)
        {
            string sql =
                @"UPDATE table_clients SET Name=@Name, Address=@Address, PhoneNumber=@PhoneNumber WHERE ClientId=@ClientId";

            return _db.ExecuteSQLQuery(sql, client);
        }

        public Task RemoveClient(ClientModel client)
        {
            string sql =
                @"DELETE FROM table_clients WHERE ClientId=@ClientId";

            return _db.ExecuteSQLQuery(sql, client);
        }


    }
}