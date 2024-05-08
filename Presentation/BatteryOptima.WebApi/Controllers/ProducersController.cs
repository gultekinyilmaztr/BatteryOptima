using BatteryOptima.Application.Features.Mediator.Commands.BatteryCellCommands;
using BatteryOptima.Application.Features.Mediator.Commands.ProducerCommands;
using BatteryOptima.Application.Features.Mediator.Queries.BatteryCellQueries;
using BatteryOptima.Application.Features.Mediator.Queries.ProducerQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BatteryOptima.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProducersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProducersController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> ProducerList()
        {
            var values = await _mediator.Send(new GetProducerQuery());
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateProducer(CreateProducerCommand command)
        {
            await _mediator.Send(command);
            return Ok("Özellik başarıyla eklendi");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveProducer(int id)
        {
            await _mediator.Send(new RemoveProducerCommand(id));
            return Ok("Özellik başarıyla silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateProducer(UpdateProducerCommand command)
        {
            await _mediator.Send(command);
            return Ok("Özellik başarıyla güncellendi");
        }
    }
}
