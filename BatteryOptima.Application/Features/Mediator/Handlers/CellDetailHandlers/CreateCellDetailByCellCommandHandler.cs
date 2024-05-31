using BatteryOptima.Application.Features.Mediator.Commands.CellDetalCommands;
using BatteryOptima.Application.Interfaces.CellDetailInterfaces;
using MediatR;
using ProductionOptima.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteryOptima.Application.Features.Mediator.Handlers.CellDetailHandlers
{
    public class CreateCellDetailByCellCommandHandler : IRequestHandler<CreateCellDetailByCellCommand>
    {
        private readonly ICellDetailRepository _repository;
        public async Task Handle(CreateCellDetailByCellCommand request, CancellationToken cancellationToken)
        {
            _repository.CreateCellDetailByCell(new CellDetail
            {
                Available = false,
                BatteryCellId = request.BatteryCellId,
                TestIR = request.TestIR,
                TestVoltage = request.TestVoltage,
                DateOfTest = request.DateOfTest,
                ProducerId = request.ProducerId,
            });
        }
    }
}
