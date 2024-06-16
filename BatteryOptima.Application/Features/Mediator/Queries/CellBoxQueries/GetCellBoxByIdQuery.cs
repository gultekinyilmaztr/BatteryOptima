using BatteryOptima.Application.Features.Mediator.Results.CellBoxResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteryOptima.Application.Features.Mediator.Queries.CellBoxQueries
{
    public class GetCellBoxByIdQuery : IRequest<GetCellBoxByIdQueryResult>
    {
        public int Id { get; set; }

        public GetCellBoxByIdQuery(int id)
        {
            Id = id;
        }
    }
}
