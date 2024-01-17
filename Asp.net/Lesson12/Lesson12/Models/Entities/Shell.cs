namespace Lesson12.Models.Entities
{
    public class Shell : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Animal> Animals { get; set; }
    }
}
