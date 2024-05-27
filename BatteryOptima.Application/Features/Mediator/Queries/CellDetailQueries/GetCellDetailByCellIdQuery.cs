using BatteryOptima.Application.Features.Mediator.Results.CellDetailResults;
using MediatR;


namespace BatteryOptima.Application.Features.Mediator.Queries.CellDetailQueries
{
    public class GetCellDetailByCellIdQuery : IRequest<List<GetCellDetailByCellIdQueryResult>>
    {
        public int Id { get; set; }

        public GetCellDetailByCellIdQuery(int id)
        {
            Id = id;
        }
    }
}
