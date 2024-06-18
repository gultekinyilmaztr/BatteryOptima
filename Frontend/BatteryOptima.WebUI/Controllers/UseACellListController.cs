using Microsoft.AspNetCore.Mvc;

namespace BatteryOptima.WebUI.Controllers
{
    public class UseACellListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
