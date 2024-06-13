using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BatteryOptima.Application.Interfaces.StatisticsInterfaces
{
    public interface IStatisticsRepository
    {
        int GetCellCount();
        double GetDailyBatteryMeasurements();
        double GetWeeklyBatteryMeasurements();
        double GetMonthlyBatteryMeasurements();
        int GetCountofDamagedBatteries();
        int GetCountofWasteBatteries();
        int GetCountofUsedBatteries();
        int GetCountofNonUsedBatteries();
        int GetCountofBatteriesAboveToleranceValue();

    }
}
