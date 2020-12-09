using System.Collections.Generic;
using System.Threading.Tasks;
using PizzaDataLibrary.Models;

namespace PizzaDataLibrary.BusinessLogic
{
    public interface IPartnerProductData
    {
        Task<List<PartnerProductModel>> GetPartnerProductListTask();
        Task<int> Add(PartnerProductModel model);
        public Task Update(PartnerProductModel model);
        Task Remove(PartnerProductModel model);
    }
}