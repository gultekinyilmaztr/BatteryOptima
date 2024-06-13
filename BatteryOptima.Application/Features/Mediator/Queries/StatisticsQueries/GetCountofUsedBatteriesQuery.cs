using BatteryOptima.Application.Features.Mediator.Results.StatisticsResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteryOptima.Application.Features.Mediator.Queries.StatisticsQueries
{
    public class GetCountofUsedBatteriesQuery : IRequest<GetCountofUsedBatteriesQueryResult>
    {
    }
}
