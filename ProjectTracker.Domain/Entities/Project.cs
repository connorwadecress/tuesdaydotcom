﻿using ProjectTracker.Domain.Interfaces;

namespace ProjectTracker.Domain.Entities
{
    public class Project : DomainObjectWithTag, IItem
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime DateCreated { get; set; }
        public DateTime? DeadlineDate { get; set; }
        public string Status { get; set; } = null!;
        public virtual ICollection<Board> Boards { get; set; } = [];
    }
}
