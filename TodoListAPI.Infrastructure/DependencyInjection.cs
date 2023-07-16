using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TodoListAPI.Application.Common.Interfaces;
using TodoListAPI.Infrastructure.Data;

namespace TodoListAPI.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureServices (this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("Default");
        services.AddDbContext<AppDbContext>(o => o.UseSqlServer(connectionString));

        services.AddScoped<IApplicationDbContext, AppDbContext>();

        return services;
    }
}
