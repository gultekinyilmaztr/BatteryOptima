using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteryOptima.Dto.CellDetailDtos
{
    public class ResultCellDetailDto
    {
        public int CellDetailId { get; set; }
        public double TestIR { get; set; }
        public double TestVoltage { get; set; }
        public DateTime DateOfTest { get; set; }
        public int CellId { get; set; }
    }
}

