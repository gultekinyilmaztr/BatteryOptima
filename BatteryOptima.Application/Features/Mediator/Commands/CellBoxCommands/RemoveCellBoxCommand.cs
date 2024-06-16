using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteryOptima.Application.Features.Mediator.Commands.CellBoxCommands
{
    public class RemoveCellBoxCommand : IRequest
    {
        public int Id { get; set; }
        public RemoveCellBoxCommand(int id)
        {
            Id = id;
        }
    }
}
