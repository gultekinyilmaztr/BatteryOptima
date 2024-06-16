using BatteryOptima.Application.Features.Mediator.Commands.BatteryCellCommands;
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
    public class CreateCellBoxCommandHandler : IRequestHandler<CreateCellBoxCommand>
    {
        private readonly IRepository<CellBox> _repository;
        public CreateCellBoxCommandHandler(IRepository<CellBox> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateCellBoxCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new CellBox
            {
                CellBoxNumber = request.CellBoxNumber,
            });
        }
    }
}
