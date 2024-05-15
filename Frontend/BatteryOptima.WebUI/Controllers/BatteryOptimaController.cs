using Microsoft.AspNetCore.Mvc;

namespace BatteryOptima.WebUI.Controllers
{
    public class BatteryOptimaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
