using BatteryOptima.Application.Features.Mediator.Queries.UseACellsQueries;
using BatteryOptima.Application.Features.Mediator.Results.CellBoxResults;
using BatteryOptima.Application.Features.Mediator.Results.UseACellsResults;
using BatteryOptima.Application.Interfaces;
using BatteryOptima.Application.Interfaces.UseACellInterfaces;
using BatteryOptima.Domain.Entities;
using MediatR;
using ProductionOptima.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteryOptima.Application.Features.Mediator.Handlers.UseACellHandler
{
    public class GetUseACellQueryHandler : IRequestHandler<GetUseACellQuery, List<GetUseACellQueryResult>>
    {
        private readonly IUseACellRepository _repository;

        public GetUseACellQueryHandler(IUseACellRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetUseACellQueryResult>> Handle(GetUseACellQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByFilterAsync(x=>x.LocationId ==request.LocationId && x.Available ==true);
            var results = values.Select(y => new GetUseACellQueryResult
            {
                BatteryCellId = y.BatteryCellId,
                CellSerialNo=y.BatteryCell.CellSerialNo,
                
            }).ToList();
            return results;
        }
    }
}
