﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteryOptima.Application.Features.Mediator.Results.UseACellsResults
{
    public class GetUseACellQueryResult
    {
        public int BatteryCellId { get; set; }
        public string CellSerialNo { get; set; }
        public string CellBoxNumber { get; set; }
        public double TestIR { get; set; }
        public double TestVoltage { get; set; }
        


    }
}
