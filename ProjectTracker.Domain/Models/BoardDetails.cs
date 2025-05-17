using ProjectTracker.Domain.Entities;

namespace ProjectTracker.Domain.Models;

public sealed record BoardDetails
{
    public Project Project { get; set; } = null!;
    public Board Board { get; set; } = null!;
    public ICollection<GroupDetails> Groups { get; set; } = [];
}