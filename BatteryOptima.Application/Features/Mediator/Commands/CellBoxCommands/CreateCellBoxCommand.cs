using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteryOptima.Application.Features.Mediator.Commands.CellBoxCommands
{
    public class CreateCellBoxCommand : IRequest
    {
        public string CellBoxNumber { get; set; }
    }
}
