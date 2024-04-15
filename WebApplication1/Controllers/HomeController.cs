using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public readonly List<Product> products;

        public HomeController() {
            products = new List<Product> {
                new Product { Id = 1, Name = "Product 1", Price = 8 },
                new Product { Id = 2, Name = "Product 2", Price = 5 },
                new Product { Id = 3, Name = "Product 3", Price = 30 },
                new Product { Id = 4, Name = "Product 4", Price = 40 },
                new Product { Id = 5, Name = "Product 5", Price = 15 }
            };
        }
        public IActionResult Index()
        {
            ViewBag.Products = products;
            return View();
        }

        public IActionResult Detail(int id) {
            var product = products.FirstOrDefault(x => x.Id == id);
            ViewBag.Product = product;
            return View();
        }
    }
}
