using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ProjectTracker.Infrastructure.Extensions;

public static class ServiceExtensions
{
    public static void AddInfrastructure(this IServiceCollection services)
    {
        services.AddDbContext<ProjectTrackerDbContext>(options =>
        {
            options.UseSqlite("Filename=ProjectTracker.db");
        });
    }
}