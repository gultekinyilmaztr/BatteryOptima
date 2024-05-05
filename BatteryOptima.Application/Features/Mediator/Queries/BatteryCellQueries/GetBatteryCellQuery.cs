using BatteryOptima.Application.Features.Mediator.Results.BatteryCellResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteryOptima.Application.Features.Mediator.Queries.BatteryCellQueries
{
    public class GetBatteryCellQuery : IRequest<List<GetBatteryCellQueryResult>>
    {
    }
}
