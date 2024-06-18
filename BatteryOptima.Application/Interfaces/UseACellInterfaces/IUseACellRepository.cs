using BatteryOptima.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BatteryOptima.Application.Interfaces.UseACellInterfaces
{
    public interface IUseACellRepository
    {
        Task<List<UseACell>> GetByFilterAsync(Expression<Func<UseACell, bool>> filter);
    }
}
