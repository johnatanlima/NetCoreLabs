using System.Collections.Generic;
using GenerationHelpers.Models;
using Microsoft.AspNetCore.Mvc;

namespace GenerationHelpers.Controllers {
    public class ProductController : Controller {

        // Edit single product
        public IActionResult Edit() {
            var product = new Product(901, "Rocket", 99.99);
           
            return View(product);
        }

        // Show a product list
        public IActionResult Show() {

            var products = new List<Product>();
            products.Add(new Product(101, "Apple", 19.99));
            products.Add(new Product(201, "Bike", 29.99));
            products.Add(new Product(301, "Couch", 39.99));
          
            return View(products);
        }
    }
}