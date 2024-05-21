using BatteryOptima.Application.Features.Mediator.Commands.BatteryCellCommands;
using BatteryOptima.Application.Features.Mediator.Commands.ProducerCommands;
using BatteryOptima.Application.Interfaces;
using MediatR;
using ProductionOptima.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteryOptima.Application.Features.Mediator.Handlers.ProducerHandlers
{
    public class RemoveProducerCommandHandler : IRequestHandler<RemoveProducerCommand>
    {
        private readonly IRepository<Producer> _repository;

        public RemoveProducerCommandHandler(IRepository<Producer> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveProducerCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
