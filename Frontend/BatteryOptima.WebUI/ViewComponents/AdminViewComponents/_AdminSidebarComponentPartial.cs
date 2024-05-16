using Microsoft.AspNetCore.Mvc;

namespace BatteryOptima.WebUI.ViewComponents.AdminViewComponents
{
    public class _AdminSidebarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
