using BatteryOptima.Dto.CellDetailDtos;
using BatteryOptima.Dto.StatisticsDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BatteryOptima.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/AdminStatistics")]
    public class AdminStatisticsController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminStatisticsController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [Route("Index")]
        public async Task<IActionResult> Index()
        {
            Random random = new Random();
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7258/api/Statistics/GetCellCount");
            if (responseMessage.IsSuccessStatusCode)
            {
                int v1 = random.Next(0,101);
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                ViewBag.v = values.cellCount;
                ViewBag.v1 = v1;
            }

            var responseMessage2 = await client.GetAsync("https://localhost:7258/api/Statistics/GetDailyBatteryMeasurements");
            if (responseMessage2.IsSuccessStatusCode)
            {
                int dailyBatteryMeasurementRandom = random.Next(0, 101);
                var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
                var values2 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData2);
                ViewBag.dailyBatteryMeasurement = values2.dailyBatteryMeasurement;
                ViewBag.dailyBatteryMeasurementRandom = dailyBatteryMeasurementRandom;
            }


            var responseMessage3 = await client.GetAsync("https://localhost:7258/api/Statistics/GetWeeklyBatteryMeasurements");
            if (responseMessage3.IsSuccessStatusCode)
            {
                int weeklyBatteryMeasurementRandom = random.Next(0, 101);
                var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
                var values3 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData3);
                ViewBag.weeklyBatteryMeasurement = values3.weeklyBatteryMeasurement;
                ViewBag.weeklyBatteryMeasurementRandom = weeklyBatteryMeasurementRandom;
            }

            var responseMessage4 = await client.GetAsync("https://localhost:7258/api/Statistics/GetMonthlyBatteryMeasurements");
            if (responseMessage4.IsSuccessStatusCode)
            {
                int monthlyBatteryMeasurementRandom = random.Next(0, 101);
                var jsonData4 = await responseMessage4.Content.ReadAsStringAsync();
                var values4 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData4);
                ViewBag.monthlyBatteryMeasurement = values4.monthlyBatteryMeasurement;
                ViewBag.monthlyBatteryMeasurementRandom = monthlyBatteryMeasurementRandom;
            }

            var responseMessage5 = await client.GetAsync("https://localhost:7258/api/Statistics/GetCountofDamagedBatteries");
            if (responseMessage5.IsSuccessStatusCode)
            {
                int countofDamagedBatteriesRandom = random.Next(0, 101);
                var jsonData5 = await responseMessage5.Content.ReadAsStringAsync();
                var values5 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData5);
                ViewBag.countofDamagedBatteries = values5.countofDamagedBatteries;
                ViewBag.countofDamagedBatteriesRandom = countofDamagedBatteriesRandom;
            }

            var responseMessage6 = await client.GetAsync("https://localhost:7258/api/Statistics/GetCountofWasteBatteries");
            if (responseMessage6.IsSuccessStatusCode)
            {
                int countofWasteBatteriesRandom = random.Next(0, 101);
                var jsonData6 = await responseMessage6.Content.ReadAsStringAsync();
                var values6 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData6);
                ViewBag.countofWasteBatteries = values6.countofWasteBatteries;
                ViewBag.countofWasteBatteriesRandom = countofWasteBatteriesRandom;
            }

            var responseMessage7 = await client.GetAsync("https://localhost:7258/api/Statistics/GetCountofUsedBatteries");
            if (responseMessage7.IsSuccessStatusCode)
            {
                int countofUsedBatteriesRandom = random.Next(0, 101);
                var jsonData7 = await responseMessage7.Content.ReadAsStringAsync();
                var values7 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData7);
                ViewBag.countofUsedBatteries = values7.countofUsedBatteries;
                ViewBag.countofUsedBatteriesRandom = countofUsedBatteriesRandom;
            }


            var responseMessage8 = await client.GetAsync("https://localhost:7258/api/Statistics/GetCountofUsedBatteries");
            if (responseMessage8.IsSuccessStatusCode)
            {
                int countofNonUsedBatteriesRandom = random.Next(0, 101);
                var jsonData8 = await responseMessage8.Content.ReadAsStringAsync();
                var values8 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData8);
                ViewBag.countofNonUsedBatteries = values8.countofNonUsedBatteries;
                ViewBag.countofNonUsedBatteriesRandom = countofNonUsedBatteriesRandom;
            }

            var responseMessage9 = await client.GetAsync("https://localhost:7258/api/Statistics/GetCountofBatteriesAboveToleranceValue");
            if (responseMessage9.IsSuccessStatusCode)
            {
                int countofBatteriesAboveToleranceValueRandom = random.Next(0, 101);
                var jsonData9 = await responseMessage9.Content.ReadAsStringAsync();
                var values9 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData9);
                ViewBag.countofBatteriesAboveToleranceValue = values9.countofBatteriesAboveToleranceValue;
                ViewBag.countofBatteriesAboveToleranceValueRandom = countofBatteriesAboveToleranceValueRandom;
            }
            return View();
        }
    }
}
