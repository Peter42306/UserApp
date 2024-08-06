using UserApp.Models;

namespace UserApp.Services
{
    public interface IUserService
    {
        Task<List<User>> GetAllUsersAsync();
        Task<User> GetUserByIdAsync(int id);
        Task CreateUserAsync(User user);
        void UpdateUser(User user);
        Task DeleteUserAsync(int id);        
    }
}
