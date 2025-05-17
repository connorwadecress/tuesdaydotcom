using ProjectTracker.Domain.Interfaces;

namespace ProjectTracker.Domain.Entities
{
    public class Issue : DomainObjectWithTag, IItem, ILinkedList
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime DateCreated { get; set; }
        public DateTime? DeadlineDate { get; set; }

        public int GroupID { get; set; }
        public Group Group { get; set; } = null!;
        public int NextID { get; set; }
    }
}
