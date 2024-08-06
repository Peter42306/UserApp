using Microsoft.EntityFrameworkCore;
using UserApp.Models;

namespace UserApp.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly UserContext _userContext;

        public UserRepository(UserContext userContext)
        {
            _userContext = userContext;
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await _userContext.Users.ToListAsync();
        }

        public async Task<User> GetByIdAsync(int id)
        {
            return await _userContext.Users.FindAsync(id);
        }

        public async Task CreateAsync(User user)
        {
            await _userContext.AddAsync(user);
            await SaveAsync();
        }

        public void Update(User user)
        {
            _userContext.Entry(user).State = EntityState.Modified;
        }

        public async Task DeleteAsync(int id)
        {
            var user = await GetByIdAsync(id);
            if (user != null)
            {
                _userContext.Users.Remove(user);
                await SaveAsync();
            }
        }

        public async Task SaveAsync()
        {
            await _userContext.SaveChangesAsync();
        }
    }
}
