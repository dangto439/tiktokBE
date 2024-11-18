using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace _3.DAL
{
    public class TiktokDbContextFactory : IDesignTimeDbContextFactory<TiktokDbContext>
    {
        public TiktokDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<TiktokDbContext>();
            optionsBuilder.UseMySql("Server=sql12.freemysqlhosting.net;Database=sql12745484;User=sql12745484;Password=76ti7Gm7VR;Port=3306;",
                            ServerVersion.AutoDetect("Server=sql12.freemysqlhosting.net;Database=sql12745484;User=sql12745484;Password=76ti7Gm7VR;Port=3306;"));

            return new TiktokDbContext(optionsBuilder.Options);
        }
    }
}
