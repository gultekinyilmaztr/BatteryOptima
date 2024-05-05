﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionOptima.Domain.Entities
{
    public class CellDetail
    {
        public int CellDetailId { get; set; }
        public double TestIR { get; set; }
        public double TestVoltage { get; set; }
        public DateTime DateOfTest { get; set; }
        public int CellId { get; set; }
        public List<BatteryCell> BatteryCells { get; set;}

    }
}