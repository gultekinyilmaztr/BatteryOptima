using BatteryOptima.Application.Features.Mediator.Results.UseACellsResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteryOptima.Application.Features.Mediator.Queries.UseACellsQueries
{
    public class GetUseACellQuery : IRequest<List<GetUseACellQueryResult>>
    {
        public int LocationId { get; set; }
        public bool Available { get; set; }
    }
}
