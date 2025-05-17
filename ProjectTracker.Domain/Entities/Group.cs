using System.Collections.ObjectModel;
using ProjectTracker.Domain.Interfaces;

namespace ProjectTracker.Domain.Entities
{
    public class Group : DomainObject, ILinkedList
    {
        public string Name { get; set; } = null!;

        public ObservableCollection<Issue> Issues { get; set; } = [];

        public int BoardID { get; set; }
        public Board Board { get; set; } = null!;
        public int NextID { get; set; }
    }
}
