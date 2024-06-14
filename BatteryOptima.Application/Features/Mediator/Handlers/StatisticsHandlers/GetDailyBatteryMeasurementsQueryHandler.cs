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
    public class GetDailyBatteryMeasurementsQueryHandler : IRequestHandler<GetDailyBatteryMeasurementsQuery, GetDailyBatteryMeasurementQueryResult>
    {
        public readonly IStatisticsRepository _repository;

        public GetDailyBatteryMeasurementsQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetDailyBatteryMeasurementQueryResult> Handle(GetDailyBatteryMeasurementsQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetDailyBatteryMeasurements();
            return new GetDailyBatteryMeasurementQueryResult
            {
                DailyBatteryMeasurement = value,
            };
        }
    }
}
