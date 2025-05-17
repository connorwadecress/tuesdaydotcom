using System.Collections.ObjectModel;
using ProjectTracker.Domain.Interfaces;

namespace ProjectTracker.Domain.Entities
{
    public class Board : DomainObjectWithTag, IProjectLink, IItem
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Status { get; set; } = null!;
        public DateTime DateCreated { get; set; }
        public DateTime? DeadlineDate { get; set; }

        public ObservableCollection<Group> Groups { get; set; } = [];

        public int ProjectID { get; set; }
        public Project Project { get; set; } = null!;
    }
}
