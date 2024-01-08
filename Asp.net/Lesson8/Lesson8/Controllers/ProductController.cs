using Lesson8.Helpers;
using Lesson8.Models;
using Lesson8.Services;
using Microsoft.AspNetCore.Mvc;

namespace Lesson8.Controllers
{
    [Route("product")]
    public class ProductController : Controller
    {
        private readonly static List<Product> products = new();
        [Route("add")]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> Add(AddProductViewModel model)
        {
            //Product product = TypeConversion.Convert<Product, AddProductViewModel>(model);

            Product product = new()
            {
                ImageUrl = await UploadFileHelper.UploadFile(model.ImageUrl),
                Name = model.Name,
                Category = model.Category,
                Description = model.Description,
                Price = model.Price,
            };
            products.Add(product);
            // add to db
            return RedirectToAction("All");
        }

        [Route("all")]
        public IActionResult All()
        {
            return View(products);
        }
    }
}
