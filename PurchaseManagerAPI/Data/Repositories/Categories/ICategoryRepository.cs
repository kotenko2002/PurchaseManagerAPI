using PurchaseManagerAPI.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PurchaseManagerAPI.Data.Repositories.Categories
{
    public interface ICategoryRepository
    {
        Task<int> AddCategoryAsync(Category category);
        Task<IEnumerable<Category>> GetAllCategories(int userId);
    }
}
