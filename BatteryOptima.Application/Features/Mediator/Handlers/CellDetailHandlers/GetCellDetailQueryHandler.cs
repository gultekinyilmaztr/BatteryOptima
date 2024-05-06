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
    public class GetCellDetailQueryHandler : IRequestHandler<GetCellDetailQuery, List<GetCellDetailQueryResult>>
    {
        private readonly IRepository<CellDetail> _repository;

        public GetCellDetailQueryHandler(IRepository<CellDetail> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetCellDetailQueryResult>> Handle(GetCellDetailQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetCellDetailQueryResult
            {
                CellDetailId = x.CellDetailId,
                TestIR=x.TestIR,
                TestVoltage=x.TestVoltage,
                DateOfTest=x.DateOfTest,
                CellId=x.CellId,

            }).ToList();
        }
    }
}
