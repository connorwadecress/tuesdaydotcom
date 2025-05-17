using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using ProjectTracker.Domain.Entities;

namespace ProjectTracker.Infrastructure.Init;

public static class DatabaseInitializer
{
    public static void ApplyMigrations(this IHost host)
    {
        using var scope = host.Services.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<ProjectTrackerDbContext>();
        context.Database.Migrate();

        // Seed predefined tags if not already present
        if (context.Tags.Any()) return;
        var tags = new[]
        {
            new Tag { Name = "IoT", Color = 0x2ecc71, IsFontBlack = false },
            new Tag { Name = "Raspberry Pi", Color = 0x3498db, IsFontBlack = false },
            new Tag { Name = "C#", Color = 0xe67e22, IsFontBlack = true },
            new Tag { Name = "React", Color = 0x61dafb, IsFontBlack = true },
            new Tag { Name = "Azure", Color = 0x0078d4, IsFontBlack = true },
            new Tag { Name = "ML", Color = 0x9b59b6, IsFontBlack = false },
            new Tag { Name = "Flutter", Color = 0x42a5f5, IsFontBlack = true },
            new Tag { Name = "PostgreSQL", Color = 0x336791, IsFontBlack = false },
            new Tag { Name = "Docker", Color = 0x0db7ed, IsFontBlack = true },
            new Tag { Name = "Rust", Color = 0xde8615, IsFontBlack = true }
        };

        context.Tags.AddRange(tags);
        context.SaveChanges();
    }
}