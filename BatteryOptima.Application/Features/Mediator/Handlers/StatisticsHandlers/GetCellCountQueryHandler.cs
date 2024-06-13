using BatteryOptima.Application.Features.Mediator.Queries.StatisticsQueries;
using BatteryOptima.Application.Features.Mediator.Results.StatisticsResults;
using BatteryOptima.Application.Interfaces.BatteryCellInterfaces;
using BatteryOptima.Application.Interfaces.CellDetailInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteryOptima.Application.Features.Mediator.Handlers.StatisticsHandlers
{
    public class GetCellCountQueryHandler : IRequestHandler<GetCellCountQuery, GetCellCountQueryResult>
    {
        private readonly IBatteryCellRepository _repository;

        public GetCellCountQueryHandler(IBatteryCellRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetCellCountQueryResult> Handle(GetCellCountQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetCellCount();
            return new GetCellCountQueryResult
            {
                CellCount = value,
            };

        }
    }
}
