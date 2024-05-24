using Microsoft.AspNetCore.Mvc;

namespace BatteryOptima.WebUI.Areas.Admin.Controllers
{

    [Area("Admin")]
    [Route("Admin/AdminCellDetail")]
    public class AdminCellDetailController : Controller
    {
        [Route("Index/{id}")]
        public IActionResult Index(int id)
        {
            return View();
        }
    }
}
