using Microsoft.EntityFrameworkCore;

namespace UserApp.Models
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {
            if (Database.EnsureCreated())
            {
                Users?.Add(new User { Name = "Ivan Ivanov", Email = "ivan_ivanov@gmail.com" });
                Users?.Add(new User { Name = "Vasily Petrov", Email = "vasily_petrov@gmail.com" });
                Users?.Add(new User { Name = "Dmitry Sidorov", Email = "dmitry_sidorov@gmail.com" });
                SaveChanges();
            }
        }

        public DbSet<User> Users { get; set; }
    }
}
