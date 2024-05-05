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
    public class UpdateBatteryCellCommandHandler : IRequestHandler<UpdateBatteryCellCommand>
    {
        private readonly IRepository<BatteryCell> _repository;

        public UpdateBatteryCellCommandHandler(IRepository<BatteryCell> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateBatteryCellCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.BatteryCellId);
            values.CellSerialNo = request.CellSerialNo;
            values.InternalResistance = request.InternalResistance;
            values.Voltage = request.Voltage;
            values.DateOfMesurementDate = request.DateOfMesurementDate;
            values.Unit= request.Unit;
            values.Statu= request.Statu;
            values.CellDetailId = request.CellDetailId;
            values.ProducerId = request.ProducerId;
            await _repository.UpdateAsync(values);
        }
    }
}
