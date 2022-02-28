using System.Reflection;
using ERP.DAL;
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
        // services.AddTransient<IUserRepository, UserRepository>();
        return null;

    }

    public static void AddBusinessLayer(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddMediatR(Assembly.GetExecutingAssembly())
            .AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
    }
}