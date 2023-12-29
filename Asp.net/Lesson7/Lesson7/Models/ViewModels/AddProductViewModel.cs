using System.ComponentModel.DataAnnotations;

namespace Lesson7.Models.ViewModels
{
    public class AddProductViewModel
    {
        [Required]
        [MinLength(2)]
        public string Title { get; set; }
        [Required]
        [MinLength(2)]
        public string Description { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public string? ImageUrl { get; set; }

        public List<int> TagIds { get; set; }
    }
}
