using Microsoft.AspNetCore.Mvc;

namespace BatteryOptima.WebUI.Controllers
{
    public class AdminCellController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminCellController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7258/api/BatteryCells");
            if(responseMessage.IsSuccessStatusCode)
            {
                var jsonData=await responseMessage.Content.ReadAsStringAsync();

            }
            return View();
        }
    }
}
