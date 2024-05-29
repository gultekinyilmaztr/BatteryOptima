using BatteryOptima.Application.Interfaces;
using BatteryOptima.Application.Interfaces.CellDetailInterfaces;
using Microsoft.EntityFrameworkCore;
using ProductionOptima.Domain.Entities;
using ProductionOptima.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteryOptima.Persistence.Repositories.CellDetailRepository
{
    public class CellDetailRepository : ICellDetailRepository
    {
        private readonly ProductionOptimaContext _context;

        public CellDetailRepository(ProductionOptimaContext context)
        {
            _context = context;
        }

        public async Task<List<CellDetail>> GetCellDetailByCellID(int cellID)
        {
            var values = await _context.CellDetails.Include(x => x.BatteryCell).Include(x => x.Producer).Where(x => x.BatteryCellId == cellID).ToListAsync();
            return values;
        }
    }
}
