using Lesson7.Data;
using Lesson7.Models;
using Lesson7.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lesson7.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public ProductController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IActionResult Index()
        {
            var products = _appDbContext.Products.Include(p => p.Category).ToList();
            return View(products);
        }

        public IActionResult Add()
        {
            var categories = _appDbContext.Categories.ToList();
            var tags = _appDbContext.Tags.ToList();
            ViewData["Categories"] = categories;
            ViewData["Tags"] = tags;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddProductViewModel product)
        {
            if (ModelState.IsValid)
            {
                //var newProduct = new Product
                //{
                //    Category = product.Category,
                //    Price = product.Price,
                //    Description = product.Description,
                //    ImageUrl = product.ImageUrl,
                //    Title = product.Title,
                //};
                //_appDbContext.Products.Add(newProduct);
                //_appDbContext.Products.Add(product);

                var tags = _appDbContext.Tags.Where(t => product.TagIds.Contains(t.Id)).ToList();

                var newProduct = new Product
                {
                    CategoryId = product.CategoryId,
                    Price = product.Price,
                    Description = product.Description,
                    ImageUrl = product.ImageUrl,
                    Title = product.Title,
                    Tags = tags
                };
                _appDbContext.Products.Add(newProduct);
                await _appDbContext.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(product);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var product = await _appDbContext.Products.FirstOrDefaultAsync(x => x.Id == id);
            if (product is not null)
            {
                _appDbContext.Products.Remove(product);
                await _appDbContext.SaveChangesAsync();
            }
            return RedirectToAction("Index");
        }
    }
}
