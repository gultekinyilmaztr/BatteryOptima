using BatteryOptima.Application.Features.Mediator.Results.BatteryCellResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteryOptima.Application.Features.Mediator.Queries.BatteryCellQueries
{
    public class GetBatteryCellByIdQuery : IRequest<GetBatteryCellByIdQueryResult>
    {
        public int Id { get; set; }

        public GetBatteryCellByIdQuery(int id) 
        {
            Id = id;
        }
    }
}
