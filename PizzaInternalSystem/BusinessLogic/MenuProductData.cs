using System.Collections.Generic;
using System.Threading.Tasks;
using PizzaDataLibrary.DataAccess;
using PizzaDataLibrary.Models;

namespace PizzaDataLibrary.BusinessLogic
{
    public class MenuProductData : IMenuProductData
    {
        private readonly ISqlDataAccess _db;
        public MenuProductData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<MenuProductModel>> GetProductsList()
        {
            string sql = "select * from products_table";
            return _db.LoadData<MenuProductModel, dynamic>(sql, new { });
        }

        public Task AddProduct(MenuProductModel product)
        {
            string sql = "insert into products_table (ProductName, ProductPrice, ProductDescription, ProductMarks) values (@ProductName, @ProductPrice, @ProductDescription, @ProductMarks)";
            return _db.ExecuteSQLQuery(sql, product);
        }

        public Task UpdateProduct(MenuProductModel product)
        {
            string sql = @"update products_table set ProductName=@ProductName, ProductPrice=@ProductPrice, ProductDescription=@ProductDescription, ProductMarks=@ProductMarks where ProductId=@ProductId";
            return _db.ExecuteSQLQuery(sql, product);
        }

        public Task RemoveProduct(MenuProductModel product)
        {
            string sql = "delete from products_table where ProductId=@ProductId";
            return _db.ExecuteSQLQuery(sql, product);
        }
    }
}