﻿using BatteryOptima.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ProductionOptima.Domain.Entities
{
    public class BatteryCell
    {
        public int BatteryCellId { get; set; }
        public string CellSerialNo { get; set; }
        public double InternalResistance { get; set; }
        public double Voltage { get; set; }
        public DateTime DateOfMesurementDate { get; set; }
        public bool Available { get; set; }
        public List<CellDetail> CellDetails { get; set; }
        public List<UseACell> UseACells { get; set; }
        public List<UseACellProcess> UseACellProcesses { get; set; }
    }
}
