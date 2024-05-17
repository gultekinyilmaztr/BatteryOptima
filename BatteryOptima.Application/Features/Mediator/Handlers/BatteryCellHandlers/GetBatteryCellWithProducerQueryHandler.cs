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
    public class GetBatteryCellWithProducerQueryHandler : IRequestHandler<GetBatteryCellWithProducerQuery, List<GetBatteryCellWithProducerQueryResult>>
    {
        private readonly IBatteryCellRepository _repository;

        public GetBatteryCellWithProducerQueryHandler(IBatteryCellRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetBatteryCellWithProducerQueryResult>> Handle(GetBatteryCellWithProducerQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetBatteryCellsWithProducers();
            return values.Select(x => new GetBatteryCellWithProducerQueryResult
            {
                ProducerId = x.ProducerId,
                ProducerName=x.Producer.ProducerName,
                CellSerialNo = x.CellSerialNo,
                InternalResistance = x.InternalResistance,
                Voltage = x.Voltage,
                DateOfMesurementDate = x.DateOfMesurementDate,
                Unit = x.Unit,
                Statu = x.Statu,
            }).ToList();
        }
    }
}
