using Microsoft.AspNetCore.Mvc;

namespace BatteryOptima.WebUI.Controllers
{
    public class CellDashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
