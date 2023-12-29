using Lesson7.Models.ViewModels;

namespace Lesson7.Models
{
    public class Product : BaseEntity
    {
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public double Price { get; set; }
        public string? ImageUrl { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public List<Tag> Tags { get; set; }

        public static implicit operator Product(AddProductViewModel viewModel)
        {
            return new()
            {
                Title = viewModel.Title,
                Description = viewModel.Description,
                CategoryId = viewModel.CategoryId,
                Price = viewModel.Price,
                ImageUrl = viewModel.ImageUrl,
            };
        }
    }
}
