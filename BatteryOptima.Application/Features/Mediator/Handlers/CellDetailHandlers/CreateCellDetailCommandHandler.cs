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
    public class CreateCellDetailCommandHandler : IRequestHandler<CreateCellDetailCommand>
    {
        private readonly IRepository<CellDetail> _repository;

        public CreateCellDetailCommandHandler(IRepository<CellDetail> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateCellDetailCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new CellDetail
            {
                TestIR = request.TestIR,
                TestVoltage = request.TestVoltage,
                DateOfTest = request.DateOfTest,
            });
        }
    }
}
