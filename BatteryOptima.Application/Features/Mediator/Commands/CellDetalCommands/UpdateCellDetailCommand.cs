﻿using MediatR;
using ProductionOptima.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteryOptima.Application.Features.Mediator.Commands.BatteryCellCommands
{
    public class UpdateCellDetailCommand : IRequest
    {
        public int CellDetailId { get; set; }
        public int BatteryCellId { get; set; }
        public int ProducerId { get; set; }
        public double TestIR { get; set; }
        public double TestVoltage { get; set; }
        public DateTime DateOfTest { get; set; }
    }
}
