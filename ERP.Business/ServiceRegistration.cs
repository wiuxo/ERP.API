using System.Reflection;
using ERP.Core.Repositories;
using ERP.DAL;
using ERP.DAL.Repositories;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ERP.Business;

public static class ServiceRegistration
{
    public static IServiceCollection RegisterDatabase(this IServiceCollection services, IConfiguration configuration)
    {
        return services.AddDbContext<AppDbContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("connectionStr"),
                sqlOptions =>
                {
                    sqlOptions
                        .EnableRetryOnFailure(
                            1,
                            TimeSpan.FromSeconds(10),
                            null);
                });
        }, ServiceLifetime.Transient, ServiceLifetime.Singleton);
    }

    public static IServiceCollection RegisterServices(this IServiceCollection services)
    {
        return services.AddTransient<IProductRepository, ProductRepository>();
    }

    public static void AddBusinessLayer(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddMediatR(Assembly.GetExecutingAssembly())
            .AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
    }
}