using BatteryOptima.Dto.BatteryCellDtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

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
            var responseMessage = await client.GetAsync("https://localhost:7258/api/BatteryCells/GetBatteryCellWithProducer");
            if(responseMessage.IsSuccessStatusCode)
            {
                var jsonData=await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultBatteryCellWithProducerDtos>>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> CreateCell()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7258/api/BatteryCells");
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultBatteryCellDto>>(jsonData);
            List<SelectListItem> batteryCellValues = (from x in values
                                                select new SelectListItem
                                                {
                                                    Text = x.CellSerialNo,
                                                    Value = x.BatteryCellId.ToString()
                                                }).ToList();
            ViewBag.BatteryCellValues = batteryCellValues;
            return View();
        }


    }
}
