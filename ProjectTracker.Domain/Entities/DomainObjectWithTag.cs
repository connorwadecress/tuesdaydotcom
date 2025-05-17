using ProjectTracker.Domain.Interfaces;

namespace ProjectTracker.Domain.Entities
{
    public class DomainObjectWithTag : DomainObject, ITag
    {
        public virtual ICollection<Tag> Tags { get; set; } = [];
    }
}
