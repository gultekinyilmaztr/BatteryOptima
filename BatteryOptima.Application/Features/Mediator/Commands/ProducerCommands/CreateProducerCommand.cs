using MediatR;
using ProductionOptima.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteryOptima.Application.Features.Mediator.Commands.ProducerCommands
{
    public class CreateProducerCommand : IRequest
    {
        public string ProducerName { get; set; }
        public string ProducerCountry { get; set; }
        public int ProducerNo { get; set; }
    }
}
