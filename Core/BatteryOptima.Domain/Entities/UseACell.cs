using ProductionOptima.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteryOptima.Domain.Entities
{
    public class UseACell
    {
        public int UseACellId { get; set; }
        public int LocationId { get; set; }
        public Location Location { get; set; }
        public int BatteryCellId { get; set; }
        public BatteryCell BatteryCell { get; set; }
        public bool Available { get; set; }
        public int CellDetailId { get; set; }
        public CellDetail CellDetail { get; set; }



    }
}
