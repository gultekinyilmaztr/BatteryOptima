using MediatR;
using ProductionOptima.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteryOptima.Application.Features.Mediator.Commands.BatteryCellCommands
{
    public class CreateCellDetailCommand : IRequest
    {
        public int BatteryCellId { get; set; }
        public int ProducerId { get; set; }
        public double TestIR { get; set; }
        public double TestVoltage { get; set; }
        public DateTime DateOfTest { get; set; }
        public bool Available { get; set; }
        public int CellBoxId { get; set; }

    }
}