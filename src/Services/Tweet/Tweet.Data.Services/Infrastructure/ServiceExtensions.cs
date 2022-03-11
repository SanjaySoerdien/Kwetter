using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Tweet.Data.Services.Interfaces;

namespace Tweet.Data.Services.Infrastructure
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<ITweetService, TweetService>();

            return services;
        }

        public static IServiceCollection AddMapper(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper(typeof(MappingProfile));

            return services;
        }
    }
}
