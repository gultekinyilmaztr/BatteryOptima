using BatteryOptima.Application.Features.Mediator.Results.CellDetailResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteryOptima.Application.Features.Mediator.Queries.CellDetailQueries
{
    public class GetCellDetailByIdQuery : IRequest<GetCellDetailByIdQueryResult>
    {
        public int Id { get; set; }
        public GetCellDetailByIdQuery(int Id) 
        {
            Id = Id;
        }
    }
}
