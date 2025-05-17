namespace ProjectTracker.Infrastructure.Entities
{
    public interface IProjectLink
    {
        int ProjectID { get; set; }
        Project Project { get; set; }
    }
}
