using Microsoft.AspNetCore.Mvc;

namespace BatteryOptima.WebUI.ViewComponents.AdminViewComponents
{
    public class _AdminScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
