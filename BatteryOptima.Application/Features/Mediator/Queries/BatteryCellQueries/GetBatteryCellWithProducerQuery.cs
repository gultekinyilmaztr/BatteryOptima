using BatteryOptima.Application.Features.Mediator.Results.BatteryCellResults;
using MediatR;

namespace BatteryOptima.Application.Features.Mediator.Queries.BatteryCellQueries
{
    public class GetBatteryCellWithProducerQuery : IRequest<List<GetBatteryCellWithProducerQueryResult>>
    {
    }
}
