using Microsoft.AspNetCore.Mvc;

namespace BatteryOptima.WebUI.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
