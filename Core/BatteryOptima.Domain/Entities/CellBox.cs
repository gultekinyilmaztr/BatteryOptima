using ProductionOptima.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteryOptima.Domain.Entities
{
    public class CellBox
    {
        public int CellBoxId { get; set; }
        public string CellBoxNumber { get; set; }
        public List<CellDetail> CellDetails { get; set; }
        public List<UseACellProcess> UseACellProcesses { get; set; }

    }
}
