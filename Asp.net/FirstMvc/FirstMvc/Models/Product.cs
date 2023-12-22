namespace FirstMvc.Models
{
    public class Product
    {
        public static int StaticId { get; set; } = 0;
        public int Id { get; set; } = StaticId++;
        public string Name { get; set; } = string.Empty;
        public double Price { get; set; }
    }
}
