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
    public class GetCountofWasteBatteriesQueryHandler : IRequestHandler<GetCountofWasteBatteriesQuery, GetCountofWasteBatteriesQueryResult>
    {
        private readonly IStatisticsRepository _repository;

        public GetCountofWasteBatteriesQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetCountofWasteBatteriesQueryResult> Handle(GetCountofWasteBatteriesQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetCountofWasteBatteries();
            return new GetCountofWasteBatteriesQueryResult
            {
                CountofWasteBatteries = value
            };

        }
    }
}
