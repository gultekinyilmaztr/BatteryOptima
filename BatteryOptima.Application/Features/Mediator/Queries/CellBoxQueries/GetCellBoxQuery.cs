using BatteryOptima.Application.Features.Mediator.Results.CellBoxResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteryOptima.Application.Features.Mediator.Queries.CellBoxQueries
{
    public class GetCellBoxQuery : IRequest<List<GetCellBoxQueryResult>>
    {
    }
}
