using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteryOptima.Application.Features.Mediator.Commands.CellDetalCommands
{
    public class UpdateCellDetailAvailableChangeToTrueCommand : IRequest
    {
        public int Id { get; set; }

        public UpdateCellDetailAvailableChangeToTrueCommand(int id)
        {
            Id = id;
        }
    }
}
