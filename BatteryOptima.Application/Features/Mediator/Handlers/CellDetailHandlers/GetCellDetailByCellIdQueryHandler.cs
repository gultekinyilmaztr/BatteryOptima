using BatteryOptima.Application.Features.Mediator.Queries.CellDetailQueries;
using BatteryOptima.Application.Features.Mediator.Results.CellDetailResults;
using BatteryOptima.Application.Interfaces.CellDetailInterfaces;
using MediatR;

namespace BatteryOptima.Application.Features.Mediator.Handlers.CellDetailHandlers
{
    public class GetCellDetailByCellIdQueryHandler : IRequestHandler<GetCellDetailByCellIdQuery, List<GetCellDetailByCellIdQueryResult>>
    {
        private readonly ICellDetailRepository _repository;
        public GetCellDetailByCellIdQueryHandler(ICellDetailRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetCellDetailByCellIdQueryResult>> Handle(GetCellDetailByCellIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetCellDetailByCellID(request.Id);
            return values.Select(x => new GetCellDetailByCellIdQueryResult
            {
                CellDetailId = x.CellDetailId,
                CellSerialNo = x.BatteryCell.CellSerialNo,
                ProducerId = x.Producer.ProducerId,
                ProducerName = x.Producer.ProducerName,
                TestIR = x.TestIR,
                TestVoltage = x.TestVoltage,
                DateOfTest = x.DateOfTest,
                Available = x.Available,
                BatteryCellId = x.BatteryCell.BatteryCellId
            }).ToList();
        }
    }
}
