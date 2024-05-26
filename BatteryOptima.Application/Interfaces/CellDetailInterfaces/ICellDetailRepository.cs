using ProductionOptima.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteryOptima.Application.Interfaces.CellDetailInterfaces
{
    public interface ICellDetailRepository
    {
        List<CellDetail> GetCellDetailByCellID(int cellID);
    }
}
