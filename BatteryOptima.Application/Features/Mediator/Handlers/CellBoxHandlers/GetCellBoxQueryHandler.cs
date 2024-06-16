using BatteryOptima.Application.Features.Mediator.Queries.CellBoxQueries;
using BatteryOptima.Application.Features.Mediator.Results.BatteryCellResults;
using BatteryOptima.Application.Features.Mediator.Results.CellBoxResults;
using BatteryOptima.Application.Interfaces;
using BatteryOptima.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteryOptima.Application.Features.Mediator.Handlers.CellBoxHandlers
{
    public class GetCellBoxQueryHandler : IRequestHandler<GetCellBoxQuery, List<GetCellBoxQueryResult>>
    {
        private readonly IRepository<CellBox> _repository;
        public GetCellBoxQueryHandler(IRepository<CellBox> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetCellBoxQueryResult>> Handle(GetCellBoxQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetCellBoxQueryResult
            {
                CellBoxId = x.CellBoxId,
                CellBoxNumber = x.CellBoxNumber,
                
            }).ToList();
        }
    }
}
