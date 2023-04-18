using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using test2.Shared;

namespace test2.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetProduct()
        {
            var p1 = new Product("pen", "pineapple");
            var p2 = new Product("pencil", "apple");
            var p3 = new Product("eraser", "lichi");
            var response = new List<Product> {p1,p2,p3};
            return Ok(response);
        }
    }
}
