using Microsoft.AspNetCore.Mvc;

namespace Lesson6.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Delete(int id)
        {
            return View();
        }
    }
}
