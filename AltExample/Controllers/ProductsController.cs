using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

/*
Here there is a ValuesController that demonstrates basic CRUD operations.

The ValuesController contains several action methods:

    - Get(): Retrieves all values.
    - Get(int id): Retrieves a specific value by its ID.
    - Post([FromBody] string value): Adds a new value.
    - Put(int id, [FromBody] string value): Updates a value by its ID.
    - Delete(int id): Deletes a value by its ID.

Microsoft.AspNetCore.Mvc is a package or library within the ASP.NET Core framework that provides support for building web applications and APIs using the MVC pattern.
It offers a range of features and functionalities to simplify the development of web applications, including handling HTTP requests and responses, routing, model binding, view rendering, and more. 
*/

namespace MyWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private static List<Product> _products = new List<Product>
        {
            new Product { Id = 1, Name = "Product 1", Price = 10.99 },
            new Product { Id = 2, Name = "Product 2", Price = 19.99 },
            new Product { Id = 3, Name = "Product 3", Price = 5.99 }
        };

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_products);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var product = _products.Find(p => p.Id == id);
            if (product == null)
                return NotFound();

            return Ok(product);
        }

        [HttpPost]
        public IActionResult Post(Product product)
        {
            product.Id = _products.Count + 1;
            _products.Add(product);
            return CreatedAtAction(nameof(Get), new { id = product.Id }, product);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Product updatedProduct)
        {
            var product = _products.Find(p => p.Id == id);
            if (product == null)
                return NotFound();

            product.Name = updatedProduct.Name;
            product.Price = updatedProduct.Price;
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var product = _products.Find(p => p.Id == id);
            if (product == null)
                return NotFound();

            _products.Remove(product);
            return NoContent();
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
