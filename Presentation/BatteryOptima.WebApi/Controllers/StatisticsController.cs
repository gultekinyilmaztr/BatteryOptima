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
    }
}
