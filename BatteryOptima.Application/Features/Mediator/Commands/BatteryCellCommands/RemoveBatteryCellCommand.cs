﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteryOptima.Application.Features.Mediator.Commands.BatteryCellCommands
{
    public class RemoveBatteryCellCommand : IRequest
    {
        public int Id { get; set; }
        public RemoveBatteryCellCommand(int id)
        {
            Id = id;
        }
    }
}
