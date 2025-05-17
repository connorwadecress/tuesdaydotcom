using ProjectTracker.Domain.Entities;

namespace ProjectTracker.Domain.Interfaces
{
    public interface IProjectLink
    {
        int ProjectID { get; set; }
        Project Project { get; set; }
    }
}
