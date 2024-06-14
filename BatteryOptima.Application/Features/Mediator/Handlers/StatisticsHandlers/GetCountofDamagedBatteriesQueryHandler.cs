using BatteryOptima.Application.Features.Mediator.Queries.StatisticsQueries;
using BatteryOptima.Application.Features.Mediator.Results.StatisticsResults;
using BatteryOptima.Application.Interfaces.StatisticsInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteryOptima.Application.Features.Mediator.Handlers.StatisticsHandlers
{
    public class GetCountofDamagedBatteriesQueryHandler : IRequestHandler<GetCountofDamagedBatteriesQuery, GetCountofDamagedBatteriesQueryResult>
    {
        private readonly IStatisticsRepository _repository;

        public GetCountofDamagedBatteriesQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetCountofDamagedBatteriesQueryResult> Handle(GetCountofDamagedBatteriesQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetCountofDamagedBatteries();
            return new GetCountofDamagedBatteriesQueryResult
            {
                CountofDamagedBatteries = value,
            };
        }
    }
}
