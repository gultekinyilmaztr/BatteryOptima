using BatteryOptima.Application.Features.Mediator.Queries.BatteryCellQueries;
using BatteryOptima.Application.Features.Mediator.Results.BatteryCellResults;
using BatteryOptima.Application.Interfaces;
using MediatR;
using ProductionOptima.Domain.Entities;

namespace BatteryOptima.Application.Features.Mediator.Handlers.BatteryCellHandlers
{
    public class GetBatteryCellByIdQueryHandler : IRequestHandler<GetBatteryCellByIdQuery, GetBatteryCellByIdQueryResult>
    {
        private readonly IRepository<BatteryCell> _repository;

        public GetBatteryCellByIdQueryHandler(IRepository<BatteryCell> repository)
        {
            _repository = repository;
        }

        public async Task<GetBatteryCellByIdQueryResult> Handle(GetBatteryCellByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetBatteryCellByIdQueryResult
            {
                BatteryCellId = values.BatteryCellId,
                CellSerialNo = values.CellSerialNo,
                InternalResistance = values.InternalResistance,
                Voltage=values.Voltage,
                DateOfMesurementDate = values.DateOfMesurementDate,
                Unit=values.Unit,
                Statu=values.Statu,
                CellDetailId=values.CellDetailId,
                ProducerId=values.ProducerId,

            };

        }
    }
}
