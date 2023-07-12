using Microsoft.Extensions.DependencyInjection;

namespace CRM.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        return services;
    }
}
