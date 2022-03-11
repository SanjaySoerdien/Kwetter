using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Tweet.Data.Infrastructure
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            return services;
        }

        public static IServiceCollection AddEfCore(this IServiceCollection services, IConfiguration configuration)
        {
            // Config van EFCore
            services.AddDbContext<ApplicationDbContext>(config =>
                config.UseSqlServer(configuration.GetConnectionString("ApplicationDbContext")));

            return services;
        }
    }
}
