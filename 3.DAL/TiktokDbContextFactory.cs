using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace _3.DAL
{
    public class TiktokDbContextFactory : IDesignTimeDbContextFactory<TiktokDbContext>
    {
        public TiktokDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<TiktokDbContext>();
            optionsBuilder.UseMySql("Server=sql12.freemysqlhosting.net;Database=sql12743985;User=sql12743985;Password=DR2KsFYuca;Port=3306;",
                            ServerVersion.AutoDetect("Server=sql12.freemysqlhosting.net;Database=sql12743985;User=sql12743985;Password=DR2KsFYuca;Port=3306;"));

            return new TiktokDbContext(optionsBuilder.Options);
        }
    }
}
