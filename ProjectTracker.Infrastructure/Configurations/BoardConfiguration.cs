﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectTracker.Domain.Entities;

namespace ProjectTracker.Infrastructure.Configurations
{
    public class BoardConfiguration : IEntityTypeConfiguration<Board>
    {
        public void Configure(EntityTypeBuilder<Board> builder)
        {
            // One-to-Many Relations
            builder.HasMany<Group>(b => b.Groups)
                   .WithOne(g => g.Board)
                   .HasForeignKey(g => g.BoardID)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany<Tag>(p => p.Tags)
                .WithMany(t => t.Boards);
        }
    }
}
