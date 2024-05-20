using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteryOptima.Dto.BatteryCellDtos
{
    public class CreateBatteryCellDto
    {

        public string CellSerialNo { get; set; }
        public int ProducerId { get; set; }
        public string ProducerName { get; set; }
        public double InternalResistance { get; set; }
        public double Voltage { get; set; }
        public DateTime DateOfMesurementDate { get; set; }
        public bool Statu { get; set; }
    }
}
