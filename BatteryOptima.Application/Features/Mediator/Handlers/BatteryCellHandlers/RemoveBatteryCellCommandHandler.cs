using BatteryOptima.Application.Features.Mediator.Commands.BatteryCellCommands;
using BatteryOptima.Application.Interfaces;
using MediatR;
using ProductionOptima.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteryOptima.Application.Features.Mediator.Handlers.BatteryCellHandlers
{
    public class RemoveBatteryCellCommandHandler : IRequestHandler<RemoveBatteryCellCommand>
    {
        private readonly IRepository<BatteryCell> _repository;

        public RemoveBatteryCellCommandHandler(IRepository<BatteryCell> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveBatteryCellCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
