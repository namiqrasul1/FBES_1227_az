using DependencyInjectionExample.Models;
using DependencyInjectionExample.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DependencyInjectionExample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILog _log;

        public HomeController(ILog log)
        {
            _log = log;
        }

        public IActionResult Index([FromServices]ILog log)
        {
            log.Log("home/index invoked");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}