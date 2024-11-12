using _3.DAL.Entity;
using Microsoft.EntityFrameworkCore;

namespace _3.DAL
{
    public class TiktokDbContext : DbContext
    {
        public TiktokDbContext(DbContextOptions<TiktokDbContext> options)
            : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
    }
}
