using BatteryOptima.Application.Features.Mediator.Commands.BatteryCellCommands;
using BatteryOptima.Application.Features.Mediator.Commands.ProducerCommands;
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
    public class CreateProducerCommandHandler : IRequestHandler<CreateProducerCommand>
    {
        private readonly IRepository<Producer> _repository;

        public CreateProducerCommandHandler(IRepository<Producer> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateProducerCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Producer
            {
                ProducerName = request.ProducerName,
                ProducerCountry = request.ProducerCountry,
                ProducerNo = request.ProducerNo,
            });

        }
    }
}
