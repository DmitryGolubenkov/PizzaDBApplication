using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using PizzaDataLibrary.DataAccess;
using PizzaDataLibrary.Models;

namespace PizzaDataLibrary.BusinessLogic
{
    public class OrderStatusData
    {
        private readonly ISqlDataAccess _db;

        public OrderStatusData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<OrderStatusModel>> GetPossibleStatusesList()
        {
            string sql = "select * from order_status_variants";
            return _db.LoadData<OrderStatusModel, dynamic>(sql, new { });
        }

        /*public Task<string> GetOrderStatusNameById(int id)
        {
            string sql = "select * from order_status_variants where status_id = @id";

            return _db.LoadData<OrderStatusModel, dynamic>(sql, new {}).Result[0].StatusDisplayName;
        }*/
    }
}