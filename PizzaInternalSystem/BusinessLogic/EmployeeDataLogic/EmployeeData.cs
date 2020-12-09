using System.Collections.Generic;
using System.Threading.Tasks;
using PizzaDataLibrary.DataAccess;
using PizzaDataLibrary.Models;

namespace PizzaDataLibrary.BusinessLogic.EmployeeDataLogic
{
    public class EmployeeData : IEmployeeData
    {
        private readonly ISqlDataAccess _db;
        public EmployeeData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<EmployeeModel>> GetEmployeesListTask()
        {
            string sql = "select * from employees_table";
            return _db.LoadData<EmployeeModel, dynamic>(sql, new { });
        }

        public Task<int> Add(EmployeeModel model)
        {
            string sql = @"insert into employees_table (FirstName, LastName, MiddleName, EmployeePosition) 
values (@FirstName, @LastName, @MiddleName, @EmployeePosition); select scope_identity()";

            return _db.InsertDataIntoDatabase(sql, model);
        }

        public Task Update(EmployeeModel model)
        {
            string sql =
                @"UPDATE employees_table SET FirstName=@FirstName, LastName=@LastName, MiddleName=@MiddleName, EmployeePosition=@EmployeePosition WHERE EmployeeId=@EmployeeId";

            return _db.ExecuteSQLQuery(sql, model);
        }

        public Task Remove(EmployeeModel model)
        {
            string sql =
                @"DELETE FROM employees_table WHERE EmployeeId=@EmployeeId";

            return _db.ExecuteSQLQuery(sql, model);
        }
    }
}