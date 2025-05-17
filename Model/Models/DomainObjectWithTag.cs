using System.Collections.Generic;

namespace WPF.ProjectTracker.Model.Models
{
    public class DomainObjectWithTag : DomainObject, ITag
    {
        public virtual ICollection<Tag> Tags { get; set; }
    }
}
