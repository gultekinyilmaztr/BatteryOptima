using Microsoft.AspNetCore.Mvc;

namespace BatteryOptima.WebUI.ViewComponents.BatteryCellFilterViewComponents
{
    public class _UseACellFilterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
