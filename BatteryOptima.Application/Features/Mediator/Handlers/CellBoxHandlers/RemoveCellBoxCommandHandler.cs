using BatteryOptima.Application.Features.Mediator.Commands.CellBoxCommands;
using BatteryOptima.Application.Interfaces;
using BatteryOptima.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteryOptima.Application.Features.Mediator.Handlers.CellBoxHandlers
{
    public class RemoveCellBoxCommandHandler : IRequestHandler<RemoveCellBoxCommand>
    {
        private readonly IRepository<CellBox> _repository;
        public RemoveCellBoxCommandHandler(IRepository<CellBox> repository)
        {
            _repository = repository;
        }
        public async Task Handle(RemoveCellBoxCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
