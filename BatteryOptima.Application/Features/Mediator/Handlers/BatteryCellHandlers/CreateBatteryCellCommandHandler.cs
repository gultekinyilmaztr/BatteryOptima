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
    public class CreateBatteryCellCommandHandler : IRequestHandler<CreateBatteryCellCommand>
    {
        private readonly IRepository<BatteryCell> _repository;

        public CreateBatteryCellCommandHandler(IRepository<BatteryCell> repository)
        {
            _repository = repository;
        }


        public async Task Handle(CreateBatteryCellCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new BatteryCell
            {
                CellSerialNo = request.CellSerialNo,
                InternalResistance = request.InternalResistance,
                Voltage=request.Voltage,
                DateOfMesurementDate = request.DateOfMesurementDate,
                Unit=request.Unit,
                Statu=request.Statu,

            });

        }
    }
}
