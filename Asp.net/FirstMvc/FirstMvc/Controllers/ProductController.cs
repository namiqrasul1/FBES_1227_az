using FirstMvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace FirstMvc.Controllers
{
    public class ProductController : Controller
    {
        private readonly static List<Product> products = new()
        {
            new Product { Name = "Cola", Price = 2},
            new Product { Name = "Fanta", Price = 2},
            new Product { Name = "Sprite", Price = 2},
        };

        [HttpGet]
        public IActionResult Details(int id)
        {
            //Product? product = products.FirstOrDefault(p => p.Id == id);
            //return View(product);

            //ViewBag.Product = products.FirstOrDefault(p => p.Id == id);

            //ViewData["Product"] = products.FirstOrDefault(p => p.Id == id);
            TempData["Product"] = JsonSerializer.Serialize(products.FirstOrDefault(p => p.Id == id));

            return RedirectToAction("Some");
        }

        public IActionResult Some()
        {
            Product? product =  JsonSerializer.Deserialize<Product>(TempData["Product"]!.ToString() ?? "");
            return RedirectToAction("GetAll");
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return View(products);
        }
    }
}
