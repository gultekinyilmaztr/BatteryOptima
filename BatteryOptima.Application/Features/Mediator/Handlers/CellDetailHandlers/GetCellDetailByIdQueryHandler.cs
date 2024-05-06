using BatteryOptima.Application.Features.Mediator.Queries.BatteryCellQueries;
using BatteryOptima.Application.Features.Mediator.Queries.CellDetailQueries;
using BatteryOptima.Application.Features.Mediator.Results.BatteryCellResults;
using BatteryOptima.Application.Features.Mediator.Results.CellDetailResults;
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
    public class GetCellDetailByIdQueryHandler : IRequestHandler<GetCellDetailByIdQuery, GetCellDetailByIdQueryResult>
    {
        private readonly IRepository<CellDetail> _repository;

        public GetCellDetailByIdQueryHandler(IRepository<CellDetail> repository)
        {
            _repository = repository;
        }

        public async Task<GetCellDetailByIdQueryResult> Handle(GetCellDetailByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetCellDetailByIdQueryResult
            {
                CellDetailId = values.CellDetailId,
                TestIR=values.TestIR,
                TestVoltage=values.TestVoltage,
                DateOfTest=values.DateOfTest,
                CellId=values.CellId,

            };
        }
    }
}
