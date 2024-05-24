using BatteryOptima.Application.Features.Mediator.Queries.BatteryCellQueries;
using BatteryOptima.Application.Features.Mediator.Results.BatteryCellResults;
using BatteryOptima.Application.Interfaces.BatteryCellInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteryOptima.Application.Features.Mediator.Handlers.BatteryCellHandlers
{
    public class GetBatteryCellWithCellDetailQueryHandler : IRequestHandler<GetBatteryCellWithCellDetailQuery, List<GetBatteryCellWithCellDetailQueryResult>>
    {
        private readonly IBatteryCellRepository _repository;

        public GetBatteryCellWithCellDetailQueryHandler(IBatteryCellRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetBatteryCellWithCellDetailQueryResult>> Handle(GetBatteryCellWithCellDetailQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetBatteryCellsWithCellDetails();
            return values.Select(x => new GetBatteryCellWithCellDetailQueryResult
            {
                BatteryCellId = x.BatteryCellId,
                CellSerialNo = x.CellSerialNo,
                InternalResistance = x.InternalResistance,
                Voltage = x.Voltage,
                DateOfMesurementDate = x.DateOfMesurementDate,
                Available = x.Available
            }).ToList();
        }
    }
}
