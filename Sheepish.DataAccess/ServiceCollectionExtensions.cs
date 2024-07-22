using Microsoft.EntityFrameworkCore;
using Sheepish.DataAccess.Context;

namespace Sheepish.DataAccess
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection RegisterDataServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(
                options => options.UseSqlite(configuration.GetConnectionString("SheepishDb"))
            );
            return services;
        }
    }
}
