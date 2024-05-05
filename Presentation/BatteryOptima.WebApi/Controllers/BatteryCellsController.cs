using BatteryOptima.Application.Features.Mediator.Commands.BatteryCellCommands;
using BatteryOptima.Application.Features.Mediator.Queries.BatteryCellQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BatteryOptima.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BatteryCellsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BatteryCellsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> BatteryCellList()
        {
            var values = await _mediator.Send(new GetBatteryCellQuery());
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateBatteryCell(CreateBatteryCellCommand command)
        {
            await _mediator.Send(command);
            return Ok("Özellik başarıyla eklendi");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveBatteryCell(int id)
        {
            await _mediator.Send(new RemoveBatteryCellCommand(id));
            return Ok("Özellik başarıyla silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateBatteryCell(UpdateBatteryCellCommand command)
        {
            await _mediator.Send(command);
            return Ok("Özellik başarıyla güncellendi");
        }

    }
}
