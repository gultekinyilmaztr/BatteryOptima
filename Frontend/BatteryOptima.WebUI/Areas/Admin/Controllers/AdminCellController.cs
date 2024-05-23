using BatteryOptima.Dto.BatteryCellDtos;
using BatteryOptima.Dto.ProducerDtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Text;

namespace BatteryOptima.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
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
            var responseMessage = await client.GetAsync("https://localhost:7258/api/BatteryCells/GetBatteryCellWithCellDetail");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
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

        public async Task<IActionResult> RemoveBatteryCell(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:7258/api/BatteryCells/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> UpdateCell(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage1 = await client.GetAsync("https://localhost:7258/api/Producers");
            var jsonData1 = await responseMessage1.Content.ReadAsStringAsync();
            var values1 = JsonConvert.DeserializeObject<List<ResultProcuderDto>>(jsonData1);
            List<SelectListItem> producerValues = (from x in values1
                                                   select new SelectListItem
                                                   {
                                                       Text = x.ProducerName,
                                                       Value = x.ProducerId.ToString()
                                                   }).ToList();
            ViewBag.ProducerValues = producerValues;
            return View();

            var responseMessage = await client.GetAsync($"https://localhost:7258/api/BatteryCells/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateBatteryCellDto>(jsonData);
                return View(values);
            }
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> UpdateCell(UpdateBatteryCellDto updateBatteryCellDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateBatteryCellDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMaessage = await client.PutAsync("https://localhost:7258/api/BatteryCells/", stringContent);
            if (responseMaessage.IsSuccessStatusCode)
            {
                return RedirectToAction("index");
            }
            return View();

        }


    }
}
