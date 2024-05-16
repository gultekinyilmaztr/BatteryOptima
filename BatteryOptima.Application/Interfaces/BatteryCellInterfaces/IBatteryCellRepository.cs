using ProductionOptima.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace BatteryOptima.Application.Interfaces.BatteryCellInterfaces
{
    public interface IBatteryCellRepository
    {
        List<BatteryCell> GetBatteryCellsWithProducers();
    }
}
