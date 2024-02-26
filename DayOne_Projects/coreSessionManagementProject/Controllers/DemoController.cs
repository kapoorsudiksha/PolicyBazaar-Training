using coreSessionManagementProject.Helpers;
using coreSessionManagementProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace coreSessionManagementProject.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            // HttpContext.Session.SetString("message", "Hello World");
            // HttpContext.Session.SetInt32("Age", 23);

            Product product = new Product() 
            { Id = 101, Name = "Product One", Price = 500 };

            SessionHelper.SetObjectAsJson(HttpContext.Session, "product", product);
            
            List<Product> products = new List<Product>()
            {
                new Product() { Id = 101, Name = "Product One", Price = 500 },
                new Product() { Id = 101, Name = "Product One", Price = 500 },
                new Product() { Id = 101, Name = "Product One", Price = 500 },
                new Product() { Id = 101, Name = "Product One", Price = 500 }
            };

            SessionHelper.SetObjectAsJson(HttpContext.Session, "products", products);

            
            return View("Index");
        }
    }
}
