using System.Collections.Generic;
using System.Threading.Tasks;
using PizzaDataLibrary.DataAccess;
using PizzaDataLibrary.Models;

namespace PizzaDataLibrary.BusinessLogic
{
    public class OrderData : IOrderData
    {
        private readonly ISqlDataAccess _db;

        public OrderData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<OrderModel>> GetOrdersListTask()
        {
            string sql = "select * from orders";
            return _db.LoadData<OrderModel, dynamic>(sql, new { });
        }

        public Task<int> AddOrder(OrderModel order)
        {
            string sql =
                @"insert into orders (ClientId, Sum, OrderTime, StatusId, OrderContents, EmployeeId) 
values (@ClientId, @Sum, @OrderTime, @StatusId, @OrderContents, @EmployeeId); select scope_identity()";

            return _db.InsertDataIntoDatabase(sql, order);
        }

        public Task UpdateOrder(OrderModel model)
        {
            string sql =
                @"UPDATE orders SET ClientId=@ClientId, Sum=@Sum, OrderTime=@OrderTime, StatusId=@StatusId, OrderContents=@OrderContents, EmployeeId=@EmployeeId WHERE OrderId=@OrderId";

            return _db.ExecuteSQLQuery(sql, model);
        }

        public Task RemoveOrder(OrderModel model)
        {
            string sql = @"DELETE FROM orders WHERE OrderId=@OrderId";

            return _db.ExecuteSQLQuery(sql, model);
        }
    }
}