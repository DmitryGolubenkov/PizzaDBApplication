using System.Collections.Generic;
using System.Threading.Tasks;
using PizzaDataLibrary.DataAccess;
using PizzaDataLibrary.Models;

namespace PizzaDataLibrary.BusinessLogic
{
    public class ProductCompositionData : IProductCompositionsData
    {
        private readonly ISqlDataAccess _db;

        public ProductCompositionData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<ProductCompositionsModel>> GetCompositionsListTask()
        {
            string sql = "select * from product_compositions";
            return _db.LoadData<ProductCompositionsModel, dynamic>(sql, new { });
        }

        public Task<int> Add(ProductCompositionsModel model)
        {
            string sql = @"insert into product_compositions (ProductId, ProductComposition) 
values (@ProductId, @ProductComposition); select scope_identity()";

            return _db.InsertDataIntoDatabase(sql, model);
        }

        public Task Update(ProductCompositionsModel model)
        {
            string sql =
                @"UPDATE product_compositions SET ProductId=@ProductId, ProductComposition=@ProductComposition WHERE CompositionId=@CompositionId";

            return _db.ExecuteSQLQuery(sql, model);
        }

        public Task Remove(ProductCompositionsModel model)
        {
            string sql =
                @"DELETE FROM product_compositions WHERE CompositionId=@CompositionId";

            return _db.ExecuteSQLQuery(sql, model);
        }
    }
}