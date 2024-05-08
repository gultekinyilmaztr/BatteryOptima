using BatteryOptima.Application.Features.Mediator.Results.ProducerResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteryOptima.Application.Features.Mediator.Queries.ProducerQueries
{
    public class GetProducerQuery : IRequest<List<GetProducerQueryResult>>
    {
    }
}
