using UserApp.Models;

namespace UserApp.Repositories
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllAsync();
        Task<User> GetByIdAsync(int id);
        Task CreateAsync(User user);
        void Update(User user);
        Task DeleteAsync(int id);
        Task SaveAsync();       
    }
}
