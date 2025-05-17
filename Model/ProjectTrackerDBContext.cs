using Microsoft.EntityFrameworkCore;
using WPF.ProjectTracker.Model.Models;

namespace WPF.ProjectTracker.Model
{
    public class ProjectTrackerDBContext : DbContext
    {
        public ProjectTrackerDBContext(DbContextOptions options) : base(options) { }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Board> Boards { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Issue> Issues { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
