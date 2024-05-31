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
    public class UpdateCellDetailAvailableChangeToTrueCommandHandler : IRequestHandler<UpdateCellDetailAvailableChangeToTrueCommand>
    {
        private readonly ICellDetailRepository _repository;

        public UpdateCellDetailAvailableChangeToTrueCommandHandler(ICellDetailRepository repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateCellDetailAvailableChangeToTrueCommand request, CancellationToken cancellationToken)
        {
            _repository.ChangeCellDetailAvailableToTrue(request.Id);
            //return Task.CompletedTask;
        }
    }
}
