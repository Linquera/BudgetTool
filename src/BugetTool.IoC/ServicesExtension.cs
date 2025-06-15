using BudgetTool.Infra.Configurations;
using Microsoft.Extensions.DependencyInjection;

namespace BugetTool.IoC;

public static class ServicesExtension
{
    public static IServiceCollection AddIoc(this IServiceCollection services) =>
        services
            .AddInfra();
}
