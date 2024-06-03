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

        public void ChangeCellDetailAvailableToFalse(int id)
        {
            var values = _context.CellDetails.Where(x=> x.CellDetailId == id).FirstOrDefault();
            values.Available = false;
            _context.SaveChanges();
        }

        public void ChangeCellDetailAvailableToTrue(int id)
        {
            var values = _context.CellDetails.Where(x => x.CellDetailId == id).FirstOrDefault();
            values.Available = true;
            _context.SaveChanges();
        }

        public void CreateCellDetailByCell(CellDetail cellDetail)
        {
            _context.CellDetails.Add(cellDetail);
            _context.SaveChanges();
        }

        public Task<List<CellDetail>> GetCellDetailByCellID(int cellID)
        {
            var values = _context.CellDetails.Include(x => x.BatteryCell).Include(x => x.Producer).Where(x => x.BatteryCellId == cellID).ToListAsync();
            return values;
        }
    }
}
