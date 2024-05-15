using Microsoft.AspNetCore.Mvc;

namespace BatteryOptima.WebUI.ViewComponents.AdminViewComponents
{
    public class _AdminNavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
