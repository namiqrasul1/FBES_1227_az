namespace Lesson13.Models
{
    public class Product
    {
        private static int _id = 1;
        public int Id { get; } = _id++;
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
    }
}
