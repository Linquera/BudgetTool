using BugetTool.IoC;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System.Text.Json.Serialization;

namespace BudgetTool.Api.Configurations;

public static class ApiServicesExtension
{
    public static IServiceCollection AddApiIoc(this IServiceCollection services, IConfiguration configuration)
    {
        return services
            .AddIoc()
            .AddHttpContextAccessor()
            .AddAuthentication().Services
            .AddAuthorization()
            .AddControllers().Services
            .AddSwaggerGen();
    }
}