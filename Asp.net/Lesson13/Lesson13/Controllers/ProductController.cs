using Lesson13.Models;
using Lesson13.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lesson13.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly static List<Product> products = new();

        [HttpGet("all")]
        public IEnumerable<Product> All([FromQuery] string? category)
        {
            if (category == null)
                return products;
            var result = products.Where(x => x.Category == category);

            return result;
        }

        [HttpGet("get/{id:int}")]
        public ActionResult<Product> Get(int id)
        {
            var product = products.FirstOrDefault(x => x.Id == id);
            return product is not null ?
                product :
                NotFound();
        }

        //[HttpGet("get/{id:int}")]
        //public IActionResult Get(int id)
        //{
        //    var product = products.FirstOrDefault(x => x.Id == id);
        //    return product is not null ?
        //        Ok(product) :
        //        NotFound();
        //}

        [HttpPost("add")]
        public IActionResult Add(AddProductViewModel model)
        {
            var product = new Product
            {
                Name = model.Name,
                Description = model.Description,
                Category = model.Category,
                Price = model.Price,
            };

            products.Add(product);
            return Ok();
        }

        [HttpDelete("delete/{id}")]
        public IActionResult Delete(int id)
        {
            var product = products.FirstOrDefault(product => product.Id == id);
            if (product is not null)
            {
                products.Remove(product);
                return StatusCode(StatusCodes.Status200OK, "object is deleted");
            }
            return BadRequest();
        }

        //[HttpPatch("update")]

    }
}
