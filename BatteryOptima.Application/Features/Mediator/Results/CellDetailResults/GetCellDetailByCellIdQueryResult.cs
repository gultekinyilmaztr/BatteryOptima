using ProductionOptima.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteryOptima.Application.Features.Mediator.Results.CellDetailResults
{
    public class GetCellDetailByCellIdQueryResult
    {
        public int CellDetailId { get; set; }
        public string CellSerialNo { get; set; }
        public int ProducerId { get; set; }
        public string ProducerName { get; set; }
        public double TestIR { get; set; }
        public double TestVoltage { get; set; }
        public DateTime DateOfTest { get; set; }
        public bool Available { get; set; }
        public int BatteryCellId { get; set; }
        public int CellBoxId { get; set; }
        public string CellBoxNumber { get; set; }
        
    }
}
