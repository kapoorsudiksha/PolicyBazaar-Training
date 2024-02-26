using coreConfigurationLibrary;
using Microsoft.AspNetCore.Mvc;

namespace coreWebConfigurationApp.Controllers
{
    public class DummyController : Controller
    {
        public readonly IConfigManager _configManager;
        public DummyController(IConfigManager configManager)
        {
            _configManager = configManager;
        }
        public IActionResult Index()
        {
            ViewBag.ApplicationVersion = this._configManager.ApplicationVersion;
            ViewBag.ApplicationName = this._configManager.ApplicationName;
            ViewBag.AppVersion = this._configManager.GetConfigurationSection("AppSettings:ApplicationVersion");
            return View();
        }
    }
}
