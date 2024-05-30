using BatteryOptima.Dto.BatteryCellDtos;
using BatteryOptima.Dto.CellDetailDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace BatteryOptima.WebUI.Areas.Admin.Controllers
{

    [Area("Admin")]
    //[Route("Admin/AdminCellDetail")]
    public class AdminCellDetailController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminCellDetailController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        //[Route("Index/{id}")]
        [HttpGet]
        public async Task<IActionResult> Index(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7258/api/CellDetails?id=" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultCellDetailByCellIdDto>>(jsonData);
                return View(values);
            }
            return View();
        }

        [HttpPost]
        [Route("Index")]

        public async Task<IActionResult> Index(List<ResultCellDetailByCellIdDto> resultCellDetailByCellIdDto)
        {
            foreach (var item in resultCellDetailByCellIdDto)
            {
                if (item.Available)
                {
                    var client = _httpClientFactory.CreateClient();
                    var jsonData = JsonConvert.SerializeObject(resultCellDetailByCellIdDto);
                    StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
                    await client.PutAsync("https://localhost:7258/api/BatteryCells/", stringContent);
                    return RedirectToAction("Index", "AdminCell");
                }
                else
                {

                }
            }
            return View();

        }
    }
}
