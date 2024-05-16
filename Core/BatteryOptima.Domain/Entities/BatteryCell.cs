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
        public int ProducerId { get; set; }
        public Producer Producer { get; set; }
        public string CellSerialNo { get; set; }
        public double InternalResistance  { get; set; }
        public double Voltage  { get; set; }
        public DateTime DateOfMesurementDate   { get; set; }
        public string Unit { get; set; }
        public bool Statu { get; set; }
        public List<CellDetail> CellDetails { get; set; }
        





    }
}
