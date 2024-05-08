using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteryOptima.Application.Features.Mediator.Commands.ProducerCommands
{
    public class RemoveProducerCommand : IRequest
    {
        public int Id { get; set; }
        public RemoveProducerCommand(int id)
        {
            Id = id;
        }
    }
}
