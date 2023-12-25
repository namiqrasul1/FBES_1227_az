using Lesson6.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Lesson6.Controllers
{
    public class AuthController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult Register(string txtEmail, string txtPass, string txtConfirm)
        //{
        //    return View();
        //}

        [HttpPost]
        public IActionResult Register(User model)
        {
            if (!ModelState.IsValid)
            {
               return View(model);
            }
            //if(model.email.Contains("@")) { } murdar usul. kixdi (pixdi)

            return View();
        }

        //[HttpPost]
        //public IActionResult Register(IFormCollection keyValuePairs)
        //{
        //    return View();
        //}

        //public IActionResult Login(string a, string b)
        //{
        //    return View();
        //}

        public IActionResult Login()
        {
            var a = Request.Query["a"].ToString();
            var b = Request.Query["b"].ToString();
            return View();
        }

    }
}
