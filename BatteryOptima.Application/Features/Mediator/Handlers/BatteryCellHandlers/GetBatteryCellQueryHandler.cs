using BatteryOptima.Application.Features.Mediator.Queries.BatteryCellQueries;
using BatteryOptima.Application.Features.Mediator.Results.BatteryCellResults;
using BatteryOptima.Application.Interfaces;
using MediatR;
using ProductionOptima.Domain.Entities;

namespace BatteryOptima.Application.Features.Mediator.Handlers.BatteryCellHandlers
{
    public class GetBatteryCellQueryHandler : IRequestHandler<GetBatteryCellQuery, List<GetBatteryCellQueryResult>>
    {
        private readonly IRepository<BatteryCell> _repository;

        public GetBatteryCellQueryHandler(IRepository<BatteryCell> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetBatteryCellQueryResult>> Handle(GetBatteryCellQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x=> new GetBatteryCellQueryResult
            {
                BatteryCellId = x.BatteryCellId,
                CellDetailId = x.CellDetailId,
                CellSerialNo = x.CellSerialNo,
                InternalResistance = x.InternalResistance,
                Voltage = x.Voltage,
                DateOfMesurementDate = x.DateOfMesurementDate,
                Unit=x.Unit,
                Statu=x.Statu,
                ProducerId=x.ProducerId,
            }).ToList();
                
        }
    }
}
