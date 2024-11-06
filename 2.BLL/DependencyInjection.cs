using _2.BLL.Interface;
using _2.BLL.Services;
using _3.DAL;
using _3.DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace _2.BLL
{
    public static class DependencyInjection
    {
        public static void ConfigureServices(this IServiceCollection services, IConfiguration configuration)
        {
            // Add DbContext
            services.AddDbContext<TiktokDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            // Register repositories and services
            services.AddScoped<IUser, UserService>();
            services.AddScoped<UserRepository>();


        }
    }
}
