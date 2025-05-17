namespace ProjectTracker.Infrastructure.Entities
{
    public interface ITag
    {
        public ICollection<Tag> Tags { get; set; }
    }
}
