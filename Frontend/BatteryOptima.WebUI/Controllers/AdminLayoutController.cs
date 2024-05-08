using Microsoft.AspNetCore.Mvc;

namespace BatteryOptima.WebUI.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
