using ProjectTracker.Domain.Entities;

namespace ProjectTracker.Domain.Interfaces
{
    public interface ITag
    {
        public ICollection<Tag> Tags { get; set; }
    }
}
