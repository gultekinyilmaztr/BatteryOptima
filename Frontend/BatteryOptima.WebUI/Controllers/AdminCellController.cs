using BatteryOptima.Dto.BatteryCellDtos;
using BatteryOptima.Dto.ProducerDtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Text;

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
                var values = JsonConvert.DeserializeObject<List<ResultBatteryCellWithCellDetailDtos>>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> CreateCell()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7258/api/Producers");
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultProcuderDto>>(jsonData);
            List<SelectListItem> producerValues = (from x in values
                                                select new SelectListItem
                                                {
                                                    Text = x.ProducerName,
                                                    Value = x.ProducerId.ToString()
                                                }).ToList();
            ViewBag.ProducerValues = producerValues;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateCell(CreateBatteryCellDto createBatteryCellDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createBatteryCellDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7258/api/BatteryCells", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }


    }
}
