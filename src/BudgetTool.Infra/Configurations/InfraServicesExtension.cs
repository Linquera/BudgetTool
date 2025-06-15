using BudgetTool.Infra.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BudgetTool.Infra.Configurations;

public static class InfraServicesExtension
{
    private const string ConnectionString = "Default";

    public static IServiceCollection AddInfra(this IServiceCollection services) =>
        services
            .AddContext()
            .AddRepositories()
            .RunMigration()
        ;

    private static IServiceCollection AddContext(this IServiceCollection services)
    {
        var connectionString = services.BuildServiceProvider().GetRequiredService<IConfiguration>().GetConnectionString(ConnectionString);
        services.AddDbContext<BudgetDbContext>(options => options.UseSqlite(connectionString));
        return services;
    }

    private static IServiceCollection AddRepositories(this IServiceCollection services) =>
        services;

    private static IServiceCollection RunMigration(this IServiceCollection services)
    {
        services.BuildServiceProvider().GetRequiredService<BudgetDbContext>().Database.Migrate();
        return services;
    }

}
