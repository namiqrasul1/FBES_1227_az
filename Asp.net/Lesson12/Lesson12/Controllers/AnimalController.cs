using Lesson12.Data;
using Lesson12.Models.Entities;
using Lesson12.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Lesson12.Controllers
{
    [Authorize]
    public class AnimalController : Controller
    {
        private readonly ShellDbContext _context;

        public AnimalController(ShellDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var animals = _context.Animals.ToList();
            return View(animals);
        }

        public IActionResult Add() => View();

        //[HttpPost]
        //public IActionResult Add(AddAnimalViewModel model)
        //{
          
        //    _context.Animals.Add(model);
        //}

    }
}
