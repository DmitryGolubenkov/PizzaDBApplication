using System.Collections.Generic;
using System.Threading.Tasks;
using PizzaDataLibrary.DataAccess;
using PizzaDataLibrary.Models;

namespace PizzaDataLibrary.BusinessLogic
{
    public class PartnerProductData : IPartnerProductData
    {
        private readonly ISqlDataAccess _db;
        public PartnerProductData(ISqlDataAccess db)
        {
            _db = db;
        }


        public Task<List<PartnerProductModel>> GetPartnerProductListTask()
        {
            string sql = "select * from partner_products";
            return _db.LoadData<PartnerProductModel, dynamic>(sql, new { });
        }

        public Task<int> Add(PartnerProductModel model)
        {
            string sql = @"insert into partner_products (ProductId, ProductPartnerPrice, ProductCount) 
values (@ProductId, @ProductPartnerPrice, @ProductCount); select scope_identity()";

            return _db.InsertDataIntoDatabase(sql, model);
        }

        public Task Update(PartnerProductModel model)
        {
            string sql =
                @"UPDATE partner_products SET ProductId=@ProductId, ProductPartnerPrice=@ProductPartnerPrice,  ProductCount=@ProductCount WHERE PartnerProductId=@PartnerProductId";

            return _db.ExecuteSQLQuery(sql, model);
        }

        public Task Remove(PartnerProductModel model)
        {
            string sql =
                @"DELETE FROM partner_products WHERE PartnerProductId=@PartnerProductId";

            return _db.ExecuteSQLQuery(sql, model);
        }
    }
}