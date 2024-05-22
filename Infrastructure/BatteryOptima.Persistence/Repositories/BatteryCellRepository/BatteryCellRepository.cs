using BatteryOptima.Application.Interfaces.BatteryCellInterfaces;
using Microsoft.EntityFrameworkCore;
using ProductionOptima.Domain.Entities;
using ProductionOptima.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteryOptima.Persistence.Repositories.BatteryCellRepository
{
    public class BatteryCellRepository : IBatteryCellRepository
    {
        private readonly ProductionOptimaContext _context;

        public BatteryCellRepository(ProductionOptimaContext context)
        {
            _context = context;
        }

        public int GetCellCount()
        {
            var value = _context.BatteryCells.Count();
            return value;
        }

        public List<BatteryCell> GetBatteryCellsWithCellDetails()
        {
            var values = _context.BatteryCells.Include(x => x.CellDetails).ToList();
            return values;
        }
    }
}
