using BatteryOptima.Application.Features.Mediator.Queries.CellBoxQueries;
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
    public class GetCellBoxByIdQueryHandler : IRequestHandler<GetCellBoxByIdQuery, GetCellBoxByIdQueryResult>
    {
        private readonly IRepository<CellBox> _repository;
        public GetCellBoxByIdQueryHandler(IRepository<CellBox> repository)
        {
            _repository = repository;
        }
        public async Task<GetCellBoxByIdQueryResult> Handle(GetCellBoxByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetCellBoxByIdQueryResult
            {
                CellBoxId = values.CellBoxId,
                CellBoxNumber = values.CellBoxNumber,

            };
        }
    }
}
