using BatteryOptima.Application.Features.Mediator.Queries.StatisticsQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BatteryOptima.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticsController : Controller
    {
        private readonly IMediator _mediator;

        public StatisticsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetCellCount")]
        public async Task<IActionResult> GetCellCount()
        {
            var values = await _mediator.Send(new GetCellCountQuery());
            return Ok(values);
        }

        [HttpGet("GetDailyBatteryMeasurements")]
        public async Task<IActionResult> GetDailyBatteryMeasurements()
        {
            var values = await _mediator.Send(new GetDailyBatteryMeasurementsQuery());
            return Ok(values);
        }

        [HttpGet("GetWeeklyBatteryMeasurements")]
        public async Task<IActionResult> GetWeeklyBatteryMeasurements()
        {
            var values = await _mediator.Send(new GetWeeklyBatteryMeasurementsQuery());
            return Ok(values);
        }

        [HttpGet("GetMonthlyBatteryMeasurements")]
        public async Task<IActionResult> GetMonthlyBatteryMeasurements()
        {
            var values = await _mediator.Send(new GetMonthlyBatteryMeasurementsQuery());
            return Ok(values);
        }

        [HttpGet("GetCountofDamagedBatteries")]
        public async Task<IActionResult> GetCountofDamagedBatteries()
        {
            var values = await _mediator.Send(new GetCountofDamagedBatteriesQuery());
            return Ok(values);
        }

        [HttpGet("GetCountofWasteBatteries")]
        public async Task<IActionResult> GetCountofWasteBatteries()
        {
            var values = await _mediator.Send(new GetCountofWasteBatteriesQuery());
            return Ok(values);
        }

        [HttpGet("GetCountofUsedBatteries")]
        public async Task<IActionResult> GetCountofUsedBatteries()
        {
            var values = await _mediator.Send(new GetCountofUsedBatteriesQuery());
            return Ok(values);
        }

        [HttpGet("GetCountofNonUsedBatteries")]
        public async Task<IActionResult> GetCountofNonUsedBatteries()
        {
            var values = await _mediator.Send(new GetCountofNonUsedBatteriesQuery());
            return Ok(values);
        }

        [HttpGet("GetCountofBatteriesAboveToleranceValue")]
        public async Task<IActionResult> GetCountofBatteriesAboveToleranceValue()
        {
            var values = await _mediator.Send(new GetCountofBatteriesAboveToleranceValueQuery());
            return Ok(values);
        }
    }
}
