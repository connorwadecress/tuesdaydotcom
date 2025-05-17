using ProjectTracker.Domain.Entities;

namespace ProjectTracker.Domain.Models;

public sealed record GroupDetails
{
    public Group Group { get; init; } = null!;
    public ICollection<Issue> Issues { get; init; } = [];
}