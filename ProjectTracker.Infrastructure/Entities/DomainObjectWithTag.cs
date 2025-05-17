namespace ProjectTracker.Infrastructure.Entities
{
    public class DomainObjectWithTag : DomainObject, ITag
    {
        public virtual ICollection<Tag> Tags { get; set; }
    }
}
