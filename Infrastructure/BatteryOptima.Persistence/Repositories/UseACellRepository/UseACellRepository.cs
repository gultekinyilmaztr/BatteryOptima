using BatteryOptima.Application.Interfaces.UseACellInterfaces;
using BatteryOptima.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using ProductionOptima.Persistence.Context;
using ProductionOptima.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BatteryOptima.Persistence.Repositories.UseACellRepository
{
    public class UseACellRepository : IUseACellRepository
    {
        private readonly ProductionOptimaContext _context;

        public UseACellRepository(ProductionOptimaContext context)
        {
            _context = context;
        }

        //public async Task<List<UseACell>> GetByFilterAsync(Expression<Func<UseACell, bool>> filter)
        //{
        //    var values = await _context.UseACells.Where(filter).Include(x => x.BatteryCell).ThenInclude(y=>y.CellDetails).ToListAsync();
        //    return values;

        //}

        public async Task<List<UseACell>> GetByFilterAsync(Expression<Func<UseACell, bool>> filter)
        {
            var values = await _context.BatteryCells.Include(x => x.UseACells).Include(x => x.CellDetails).ToListAsync();
        }
    }
}
