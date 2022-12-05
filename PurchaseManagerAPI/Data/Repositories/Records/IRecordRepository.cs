using PurchaseManagerAPI.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PurchaseManagerAPI.Data.Repositories.Records
{
    public interface IRecordRepository
    {
        Task<int> AddRecordAsync(Record record);
        Task<IEnumerable<Record>> GetRecordsByUserId(int userId);
        Task<IEnumerable<Record>> GetRecordsByUserIdAndCategoryId(int userId, int categoryId);
    }
}
