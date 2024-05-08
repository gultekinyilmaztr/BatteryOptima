using BatteryOptima.Application.Features.Mediator.Queries.ProducerQueries;
using BatteryOptima.Application.Features.Mediator.Results.BatteryCellResults;
using BatteryOptima.Application.Features.Mediator.Results.ProducerResults;
using BatteryOptima.Application.Interfaces;
using MediatR;
using ProductionOptima.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteryOptima.Application.Features.Mediator.Handlers.ProducerHandlers
{
    public class GetProducerQueryHandler : IRequestHandler<GetProducerQuery, List<GetProducerQueryResult>>
    {
        private readonly IRepository<Producer> _repository;

        public GetProducerQueryHandler(IRepository<Producer> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetProducerQueryResult>> Handle(GetProducerQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetProducerQueryResult
            {
                ProducerId = x.ProducerId,
                ProducerName = x.ProducerName,
                ProducerCountry = x.ProducerCountry,
                ProducerNo = x.ProducerNo,
            }).ToList();
        }
    }
}
