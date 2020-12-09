using System.Collections.Generic;
using System.Threading.Tasks;
using PizzaDataLibrary.Models;

namespace PizzaDataLibrary.BusinessLogic.EmployeeDataLogic
{
    public interface IEmployeeData
    {
        Task<List<EmployeeModel>> GetEmployeesListTask();
        Task<int> Add(EmployeeModel model);
        public Task Update(EmployeeModel model);
        Task Remove(EmployeeModel model);
    }
}