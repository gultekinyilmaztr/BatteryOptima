using Microsoft.AspNetCore.Mvc;

namespace BatteryOptima.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
