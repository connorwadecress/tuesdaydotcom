using System;
using System.Collections.ObjectModel;

namespace WPF.ProjectTracker.Model.Models
{
    public class Board : DomainObjectWithTag, IProjectLink, IItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DeadlineDate { get; set; }

        public ObservableCollection<Group> Groups { get; set; }

        public int ProjectID { get; set; }
        public Project Project { get; set; }
    }
}
