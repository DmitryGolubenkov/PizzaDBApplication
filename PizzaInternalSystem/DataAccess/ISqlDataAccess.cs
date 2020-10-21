using System.Collections.Generic;
using System.Threading.Tasks;

namespace PizzaDataLibrary.DataAccess
{
    public interface ISqlDataAccess
    {
        public Task<List<T>> LoadData<T, U>(string sql, U parameters);
        public Task ExecuteSQLQuery<T>(string sql, T data);
    }
}