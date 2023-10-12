using Core.Repositories;
using Core.Services;
using Infrastructure.Cache;
using Infrastructure.Datas;
using Infrastructure.Emails;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class InfrastructureServiceRegistration
{
    public static IServiceCollection RegisterInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("default");
        services.AddDbContext<DatabaseContext>(
            option => option.UseSqlServer(connectionString)
        );

        services.AddScoped<IEmailSender, FakeEmailSender>();
        services.AddScoped<ICache, FakeCache>();

        services.AddScoped<IEntityTypeRepository, EntityTypeRepository>();

        return services;
    }
}