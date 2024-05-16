using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionOptima.Domain.Entities
{
    public class Producer
    {
        public int ProducerId { get; set; }
        public string ProducerName { get; set; }
        public string ProducerCountry { get; set; }
        public int ProducerNo { get; set; }
        public List<BatteryCell> BatteryCells { get; set;}

    }
}
