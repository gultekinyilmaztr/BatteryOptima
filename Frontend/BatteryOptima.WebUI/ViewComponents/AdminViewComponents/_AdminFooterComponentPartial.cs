using Microsoft.AspNetCore.Mvc;

namespace BatteryOptima.WebUI.ViewComponents.AdminViewComponents
{
    public class _AdminFooterComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
