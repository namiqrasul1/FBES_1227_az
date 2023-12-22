using Microsoft.AspNetCore.Mvc;

namespace Lesson5.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            List<string> images = new()
            {
                "https://www.oconnorstrata.com.au/wp-content/uploads/2016/10/WSG00064-1200x400.jpg",
                "https://i.pinimg.com/originals/36/f0/1c/36f01c906486e21777228d329383d189.jpg",
                "https://cdn.visualwilderness.com/wp-content/uploads/2017/10/Mountain-Photography-Chrissy-Donadi-1.jpg"
            };
            return View(images);
        }
    }
}
