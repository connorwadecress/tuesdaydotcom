using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;

namespace ProjectTracker.Infrastructure.Init;

public static class DatabaseInitializer
{
    public static void ApplyMigrations(this IHost host)
    {
        using var scope = host.Services.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<ProjectTrackerDbContext>();
        context.Database.Migrate();
    }
}