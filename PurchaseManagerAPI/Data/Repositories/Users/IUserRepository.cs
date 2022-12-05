using PurchaseManagerAPI.Entities;
using System.Threading.Tasks;

namespace PurchaseManagerAPI.Data.Repositories.Users
{
    public interface IUserRepository
    {
        Task<bool> UserWithSuchLoginExists(string login);
        Task<User> FindUserByLoginAsync(string login);
        Task ChangeUserDefaultСurrencyAsync(int userId, int currencyId);
        Task<int> GetUserDefaultСurrencyAsync(int userId);
        Task AddUserAsync(User user);
    }
}
