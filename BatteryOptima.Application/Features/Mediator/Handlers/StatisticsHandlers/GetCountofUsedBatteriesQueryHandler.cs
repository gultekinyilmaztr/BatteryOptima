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
    public class GetCountofUsedBatteriesQueryHandler : IRequestHandler<GetCountofUsedBatteriesQuery, GetCountofUsedBatteriesQueryResult>
    {
        private readonly IStatisticsRepository _repository;

        public GetCountofUsedBatteriesQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetCountofUsedBatteriesQueryResult> Handle(GetCountofUsedBatteriesQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetCountofUsedBatteries();
            return new GetCountofUsedBatteriesQueryResult
            {
                CountofUsedBatteries = value,
            };
        }
    }
}
