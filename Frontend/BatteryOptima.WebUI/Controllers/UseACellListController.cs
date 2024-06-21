using BatteryOptima.Dto.CellDetailDtos;
using BatteryOptima.Dto.UseACellDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading;

namespace BatteryOptima.WebUI.Controllers
{
    public class UseACellListController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public UseACellListController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IActionResult> Index(int id)
        {

            var locationId = TempData["locationId"];




            //filterUseACellDto.locationId = int.Parse(locationId.ToString());
            //filterUseACellDto.available=true;

            id = int.Parse(locationId.ToString());


            ViewBag.locationId = locationId;


            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7258/api/UseACells?locationId={id}&available=true");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<FilterUseACellDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
