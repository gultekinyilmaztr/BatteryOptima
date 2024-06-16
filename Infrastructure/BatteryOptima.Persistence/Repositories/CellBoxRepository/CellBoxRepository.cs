using BatteryOptima.Application.Interfaces.CellBoxInterfaces;
using ProductionOptima.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteryOptima.Persistence.Repositories.CellBoxRepository
{
    public class CellBoxRepository : ICellBoxRepository
    {
        private readonly ProductionOptimaContext _context;

        public CellBoxRepository(ProductionOptimaContext context)
        {
            _context = context;
        }
    }
}
