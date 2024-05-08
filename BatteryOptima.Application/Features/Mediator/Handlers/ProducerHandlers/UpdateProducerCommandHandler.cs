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
    public class UpdateProducerCommandHandler : IRequestHandler<UpdateProducerCommand>
    {
        private readonly IRepository<Producer> _repository;

        public UpdateProducerCommandHandler(IRepository<Producer> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateProducerCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.ProducerId);
            values.ProducerName = request.ProducerName;
            values.ProducerNo = request.ProducerNo;
            values.ProducerCountry = request.ProducerCountry;          
            await _repository.UpdateAsync(values);
        }
    }
}
