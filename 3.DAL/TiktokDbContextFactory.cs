using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace _3.DAL
{
    public class TiktokDbContextFactory : IDesignTimeDbContextFactory<TiktokDbContext>
    {
        public TiktokDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<TiktokDbContext>();
            optionsBuilder.UseSqlServer("Server=(local);Database=TiktokDb;User Id=sa;Password=12345;MultipleActiveResultSets=true;TrustServerCertificate=True;");

            return new TiktokDbContext(optionsBuilder.Options);
        }
    }
}
