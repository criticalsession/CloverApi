using Microsoft.Extensions.DependencyInjection;

namespace CloverApi.Api.Extensions;

public static class CloverApiServiceCollectionExtensions
{
    public static IServiceCollection AddCloverApi(this IServiceCollection services)
    {
        services.AddHttpClient<CloverApiClient>(client =>
        {
            client.BaseAddress = new Uri("https://a.4cdn.org/"); // TODO: move to settings
        });

        return services;
    }
}