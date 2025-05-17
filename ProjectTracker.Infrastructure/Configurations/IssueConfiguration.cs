using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectTracker.Infrastructure.Entities;

namespace ProjectTracker.Infrastructure.Configurations
{
    class IssueConfiguration : IEntityTypeConfiguration<Issue>
    {
        public void Configure(EntityTypeBuilder<Issue> builder)
        {
            // One-to-Many Relations
            builder.HasMany<Tag>(p => p.Tags)
                .WithMany(t => t.Issues);
        }
    }
}
