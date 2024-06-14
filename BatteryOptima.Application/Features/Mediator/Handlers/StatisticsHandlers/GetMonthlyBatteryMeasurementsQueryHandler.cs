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
    public class GetMonthlyBatteryMeasurementsQueryHandler : IRequestHandler<GetMonthlyBatteryMeasurementsQuery, GetMonthlyBatteryMeasurementQueryResult>
    {
        public readonly IStatisticsRepository _repository;

        public GetMonthlyBatteryMeasurementsQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetMonthlyBatteryMeasurementQueryResult> Handle(GetMonthlyBatteryMeasurementsQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetDailyBatteryMeasurements();
            return new GetMonthlyBatteryMeasurementQueryResult
            {
                MonthlyBatteryMeasurement = value,
            };
        }
    }
}
