using Microsoft.AspNetCore.Mvc;

namespace BatteryOptima.WebUI.Controllers
{
    public class AdminCellController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
