using System.Collections.Generic;
using System.Threading.Tasks;
using PizzaDataLibrary.DataAccess;
using PizzaDataLibrary.Models;

namespace PizzaDataLibrary.BusinessLogic
{
    public class OrderData
    {
        private readonly ISqlDataAccess _db;

        public OrderData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<OrderModel>> GetOrdersList()
        {
            string sql = "select * from orders";
            return _db.LoadData<OrderModel, dynamic>(sql, new { });
        }

        public Task InsertOrderForced(OrderModel order)
        {
            string sql =
                @"insert into orders (client_id, employee_personal_id, sum, order_time, status_id, order_contents) 
values (@ClientId, @EmployeePersonalId, @Sum, @OrderTime, @StatusId, @OrderContents)";

            return _db.ExecuteSQLQuery(sql, order);
        }
    }
}