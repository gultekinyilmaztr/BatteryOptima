using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteryOptima.Dto.BatteryCellDtos
{
    public class ResultBatteryCellWithCellDetailDtos
    {
        public int BatteryCellId { get; set; }
        public string CellSerialNo { get; set; }
        public int CellDetailId { get; set; }
        public double InternalResistance { get; set; }
        public double Voltage { get; set; }
        public DateTime DateOfMesurementDate { get; set; }
        public bool Available { get; set; }
    }
}

