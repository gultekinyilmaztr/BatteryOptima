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
    public class GetCountofBatteriesAboveToleranceValueQueryHandler : IRequestHandler<GetCountofBatteriesAboveToleranceValueQuery, GetCountofBatteriesAboveToleranceValueQueryResult>
    {
        private readonly IStatisticsRepository _repository;

        public GetCountofBatteriesAboveToleranceValueQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetCountofBatteriesAboveToleranceValueQueryResult> Handle(GetCountofBatteriesAboveToleranceValueQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetCountofBatteriesAboveToleranceValue();
            return new GetCountofBatteriesAboveToleranceValueQueryResult
            {
                CountofBatteriesAboveToleranceValue = value,
            };
        }
    }
}
