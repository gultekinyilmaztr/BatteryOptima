using BatteryOptima.Application.Interfaces;
using BatteryOptima.Application.Interfaces.CellDetailInterfaces;
using ProductionOptima.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteryOptima.Persistence.Repositories.CellDetailRepository
{
    public class CellDetailRepository : ICellDetailRepository
    {
        private readonly IRepository<CellDetail> _repository;
        public List<CellDetail> GetCellDetailByCellID(int cellID)
        {
            throw new NotImplementedException();
        }
    }
}
