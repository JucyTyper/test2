using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.Serialization;
using test2.Shared;

namespace test2.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public static  Product p1 = new Product("pen", "pineapple");
        public static  Product p2 = new Product("pencil", "apple");
        public static Product p3 = new Product("eraser", "lichi");
        public static List <Product> products = new List<Product> {p1,p2,p3};

        [HttpGet]
        public IActionResult GetProduct()
        {

            var response = products;
            return Ok(response);
        }
        [HttpPost]
        public IActionResult PostProduct(AddProduct product)
        {
            var prod = new Product(product);
            products.Add(prod);
            var response = products;
            return Ok(response);
        }
    }
}
