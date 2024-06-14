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
    public class GetCountofNonUsedBatteriesQueryHandler : IRequestHandler<GetCountofNonUsedBatteriesQuery, GetCountofNonUsedBatteriesQueryResult>
    {
        private readonly IStatisticsRepository _repository;

        public GetCountofNonUsedBatteriesQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetCountofNonUsedBatteriesQueryResult> Handle(GetCountofNonUsedBatteriesQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetCountofNonUsedBatteries();
            return new GetCountofNonUsedBatteriesQueryResult
            {
                CountofNonUsedBatteries = value,
            };
        }
    }
}
