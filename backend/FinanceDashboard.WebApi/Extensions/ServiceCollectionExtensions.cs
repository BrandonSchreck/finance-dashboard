using FinanceDashboard.WebApi.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace FinanceDashboard.WebApi.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddSwagger(this IServiceCollection services)
    {
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        return services;
    }

    public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration config, IWebHostEnvironment env)
    {
        if (env.IsDevelopment()) 
        {
            services.AddDbContext<FinanceDashboardDbContext>(opts => {
                opts.UseNpgsql(config.GetConnectionString("DefaultConnection"))
                    .EnableDetailedErrors()
                    .EnableSensitiveDataLogging();
            });
        }
        else
        {
            services.AddDbContext<FinanceDashboardDbContext>(opts =>
                opts.UseNpgsql(config.GetConnectionString("DefaultConnection"))
            );
        }

        return services;
    }
}