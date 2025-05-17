namespace ProjectTracker.Infrastructure.Entities
{
    public class Tag : DomainObject, IItem
    {
        public string Name { get; set; }
        public int Color { get; set; }
        public bool IsFontBlack { get; set; }

        public virtual ICollection<Project> Projects { get; set; }
        public virtual ICollection<Board> Boards { get; set; }
        public virtual ICollection<Issue> Issues { get; set; }
    }
}
