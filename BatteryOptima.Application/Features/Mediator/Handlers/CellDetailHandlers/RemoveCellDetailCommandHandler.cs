using BatteryOptima.Application.Features.Mediator.Commands.BatteryCellCommands;
using BatteryOptima.Application.Interfaces;
using MediatR;
using ProductionOptima.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteryOptima.Application.Features.Mediator.Handlers.CellDetailHandlers
{
    public class RemoveCellDetailCommandHandler : IRequestHandler<RemoveCellDetailCommand>
    {
        private readonly IRepository<CellDetail> _repository;

        public RemoveCellDetailCommandHandler(IRepository<CellDetail> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveCellDetailCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
