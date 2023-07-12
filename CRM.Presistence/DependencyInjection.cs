using Microsoft.Extensions.DependencyInjection;

namespace CRM.Presistence;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistence(this IServiceCollection services)
    {
        return services;
    }
}
