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
    public class UpdateCellBoxCommandHandler : IRequestHandler<UpdateCellBoxCommand>
    {
        private readonly IRepository<CellBox> _repository;
        public UpdateCellBoxCommandHandler(IRepository<CellBox> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateCellBoxCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.CellBoxId);
            values.CellBoxNumber = request.CellBoxNumber;
            await _repository.UpdateAsync(values);
        }
    }
}
