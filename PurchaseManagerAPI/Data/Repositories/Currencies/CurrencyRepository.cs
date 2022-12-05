using Microsoft.EntityFrameworkCore;
using PurchaseManagerAPI.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PurchaseManagerAPI.Data.Repositories.Currencies
{
    public class CurrencyRepository : ICurrencyRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public CurrencyRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Currency>> GetAllCategories()
        {
            return await _dbContext.Currencies.ToListAsync();
        }
    }
}
