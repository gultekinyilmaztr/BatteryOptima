using BatteryOptima.Application.Features.Mediator.Queries.UseACellsQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace BatteryOptima.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UseACellController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UseACellController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetUseACellListByLocation(int locationId, bool available)
        {
            GetUseACellQuery getUseACellQuery = new GetUseACellQuery()
            {
                Available = available,
                LocationId = locationId
            };
            var values = await _mediator.Send(getUseACellQuery);
            return Ok(values);
        }

    }
}
