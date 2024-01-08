﻿namespace Lesson8.Models
{
    public class AddProductViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public IFormFile ImageUrl { get; set; }
    }
}
