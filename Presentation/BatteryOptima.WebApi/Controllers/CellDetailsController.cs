using BatteryOptima.Application.Features.Mediator.Commands.BatteryCellCommands;
using BatteryOptima.Application.Features.Mediator.Queries.BatteryCellQueries;
using BatteryOptima.Application.Features.Mediator.Queries.CellDetailQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BatteryOptima.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CellDetailsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CellDetailsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> CellDetailList()
        {
            var values = await _mediator.Send(new GetCellDetailQuery());
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateCellDetail(CreateCellDetailCommand command)
        {
            await _mediator.Send(command);
            return Ok("Özellik başarıyla eklendi");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveCellDetail(int id)
        {
            await _mediator.Send(new RemoveCellDetailCommand(id));
            return Ok("Özellik başarıyla silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCellDetail(UpdateCellDetailCommand command)
        {
            await _mediator.Send(command);
            return Ok("Özellik başarıyla güncellendi");
        }
    }
}
