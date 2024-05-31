using BatteryOptima.Application.Features.Mediator.Commands.CellDetalCommands;
using BatteryOptima.Application.Interfaces.CellDetailInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteryOptima.Application.Features.Mediator.Handlers.CellDetailHandlers
{
    public class UpdateCellDetailAvailableChangeToFalseCommandHandler : IRequestHandler<UpdateCellDetailAvailableChangeToFalseCommand>
    {
        private readonly ICellDetailRepository _repository;

        public UpdateCellDetailAvailableChangeToFalseCommandHandler(ICellDetailRepository repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateCellDetailAvailableChangeToFalseCommand request, CancellationToken cancellationToken)
        {
            _repository.ChangeCellDetailAvailableToFalse(request.Id);
            //return Task.CompletedTask;
        }
    }
}
