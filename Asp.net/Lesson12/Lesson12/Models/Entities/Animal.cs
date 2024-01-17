using Lesson12.Models.Enums;

namespace Lesson12.Models.Entities
{
    public class Animal : BaseEntity
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public Type Type { get; set; }
        public string TypeId { get; set; }
        public string ShellId { get; set; }
        public Shell Shell { get; set; }

    }
}
