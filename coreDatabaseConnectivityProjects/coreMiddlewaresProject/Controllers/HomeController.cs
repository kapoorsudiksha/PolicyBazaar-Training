using coreMiddlewaresProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace coreMiddlewaresProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IConfiguration configuration;

        public HomeController(ILogger<HomeController> logger, IConfiguration _configuration)
        {
            configuration = _configuration;
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.Message = configuration["Message"];
            ViewBag.Config1 = configuration["MyConfigs:Config1"];
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
