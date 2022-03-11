using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Tweet.Data.Infrastructure;

namespace Tweet.Data;
public static class DependencyInjection
{
    public static IServiceCollection AddTweetData(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddServices();
        services.AddEfCore(configuration);

        return services;
    }
}
