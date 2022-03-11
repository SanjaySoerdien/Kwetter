using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Tweet.Data.Services.Infrastructure;

namespace Tweet.Data.Services;
public static class DependencyInjection
{
    public static IServiceCollection AddTweetDataServices(this IServiceCollection services, IConfiguration configuration)
    {
        services = ServiceExtensions.AddServices(services);
        services.AddMapper(configuration);

        // DI Tweet.Data
        services.AddTweetData(configuration);

        return services;
    }
}
