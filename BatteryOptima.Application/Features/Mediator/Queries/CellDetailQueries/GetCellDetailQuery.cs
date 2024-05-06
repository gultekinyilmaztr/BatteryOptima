using BatteryOptima.Application.Features.Mediator.Results.CellDetailResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteryOptima.Application.Features.Mediator.Queries.CellDetailQueries
{
    public class GetCellDetailQuery : IRequest<List<GetCellDetailQueryResult>>
    {
    }
}
