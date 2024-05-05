﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteryOptima.Application.Features.Mediator.Results.BatteryCellResults
{
    public class GetBatteryCellQueryResult
    {
        public int BatteryCellId { get; set; }
        public string CellSerialNo { get; set; }
        public double InternalResistance { get; set; }
        public double Voltage { get; set; }
        public DateTime DateOfMesurementDate { get; set; }
        public string Unit { get; set; }
        public bool Statu { get; set; }
        public int CellDetailId { get; set; }
        public int ProducerId { get; set; }

    }
}