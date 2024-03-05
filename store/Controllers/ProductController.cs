using Microsoft.AspNetCore.Mvc;
using store.Models;
using static store.Models.Product;

namespace MyRestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private static readonly List<Product> Products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Price = 1000 },
            new Product { Id = 2, Name = "Smartphone", Price = 500 }
        };

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return Products;
        }

        [HttpGet("{id}")]
        public ActionResult<Product> Get(int id)
        {
            var product = Products.FirstOrDefault(p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            return product;
        }

        // Add more CRUD operations here (POST, PUT, DELETE)
    }
}