using BatteryOptima.Application.Features.Mediator.Queries.BatteryCellQueries;
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
    public class GetProducerByIdQueryHandler : IRequestHandler<GetProducerByIdQuery, GetProducerByIdQueryResult>
    {
        private readonly IRepository<Producer> _repository;

        public GetProducerByIdQueryHandler(IRepository<Producer> repository)
        {
            _repository = repository;
        }

        public async Task<GetProducerByIdQueryResult> Handle(GetProducerByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetProducerByIdQueryResult
            {
                ProducerId = values.ProducerId,
                ProducerName = values.ProducerName,
                ProducerCountry = values.ProducerCountry,
                ProducerNo = values.ProducerNo,

            };
        }
    }
}
