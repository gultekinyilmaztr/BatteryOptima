using BatteryOptima.Application.Features.Mediator.Commands.BatteryCellCommands;
using BatteryOptima.Application.Features.Mediator.Commands.CellBoxCommands;
using BatteryOptima.Application.Features.Mediator.Queries.BatteryCellQueries;
using BatteryOptima.Application.Features.Mediator.Queries.CellBoxQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BatteryOptima.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CellBoxesCOntroller : Controller
    {
        private readonly IMediator _mediator;

        public CellBoxesCOntroller(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> CellBoxList()
        {
            var values = await _mediator.Send(new GetCellBoxQuery());
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateCellBox(CreateCellBoxCommand command)
        {
            await _mediator.Send(command);
            return Ok("Özellik başarıyla eklendi");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveCellBox(int id)
        {
            await _mediator.Send(new RemoveCellBoxCommand(id));
            return Ok("Özellik başarıyla silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCellBox(UpdateCellBoxCommand command)
        {
            await _mediator.Send(command);
            return Ok("Özellik başarıyla güncellendi");
        }
    }
}
