using System.Reflection;
using Microsoft.EntityFrameworkCore;
using ProjectTracker.Infrastructure.Entities;

namespace ProjectTracker.Infrastructure;

public sealed class ProjectTrackerDbContext(DbContextOptions<ProjectTrackerDbContext> options) : DbContext(options)
{
    public DbSet<Project> Projects { get; set; }
    public DbSet<Board> Boards { get; set; }
    public DbSet<Group> Groups { get; set; }
    public DbSet<Issue> Issues { get; set; }
    public DbSet<Tag> Tags { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}