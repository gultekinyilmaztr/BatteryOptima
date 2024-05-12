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
    public class UpdateCellDetailCommandHandler : IRequestHandler<UpdateCellDetailCommand>
    {
        private readonly IRepository<CellDetail> _repository;

        public UpdateCellDetailCommandHandler(IRepository<CellDetail> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateCellDetailCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.CellDetailId);
            values.TestIR=request.TestIR;
            values.TestVoltage=request.TestVoltage;
            values.DateOfTest=request.DateOfTest;
            await _repository.UpdateAsync(values);
        }
    }
}
