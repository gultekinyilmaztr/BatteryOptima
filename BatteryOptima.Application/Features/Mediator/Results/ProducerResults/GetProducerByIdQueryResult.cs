using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteryOptima.Application.Features.Mediator.Results.ProducerResults
{
    public class GetProducerByIdQueryResult
    {
        public int ProducerId { get; set; }
        public string ProducerName { get; set; }
        public string ProducerCountry { get; set; }
        public int ProducerNo { get; set; }
    }
}
