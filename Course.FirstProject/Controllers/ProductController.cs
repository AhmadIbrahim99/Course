using Course.FirstProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace Course.FirstProject.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //The Default takes all http method
        public IActionResult GetName() => Ok("Ahmad Ibrahim Abo Naja");

        [HttpPost]
        public IActionResult GetProduct() {
            var product = new Product{ Id = 1, Name = "Car", Price = 99.99, CreatedBy = "Ahmad Ibrahim Abo Naja" };
            return Ok($"The Product Price is : {product.Price}\nAll Info About Product :\n{product.ToString()}");
        }
    }
}
