using PurchaseManagerAPI.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PurchaseManagerAPI.Data.Repositories.Currencies
{
    public interface ICurrencyRepository
    {
        Task<IEnumerable<Currency>> GetAllCategories();
    }
}
