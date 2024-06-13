using BatteryOptima.Application.Interfaces.StatisticsInterfaces;
using ProductionOptima.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteryOptima.Persistence.Repositories.StatisticsRepository
{
    public class StatisticsRepository : IStatisticsRepository
    {
        private readonly ProductionOptimaContext _context;

        public StatisticsRepository(ProductionOptimaContext context)
        {
            _context = context;
        }

        public int GetCellCount()
        {
            var value = _context.BatteryCells.Count();
            return value;
        }
       
        public int GetCountofBatteriesAboveToleranceValue()
        {
            var value = _context.CellDetails.Where(x=> x.TestIR >= 3).Count();
            return value;
        }

        public int GetCountofDamagedBatteries()
        {
            var value = _context.CellDetails.Where(x => !x.Available).Count();
            return value;
        }

        public int GetCountofNonUsedBatteries()
        {
            throw new NotImplementedException();
        }

        public int GetCountofUsedBatteries()
        {
            throw new NotImplementedException();
        }

        public int GetCountofWasteBatteries()
        {
            throw new NotImplementedException();
        }

        public double GetDailyBatteryMeasurements()
        {
            DateTime today = DateTime.Today;

            var value = _context.CellDetails.Where(x => x.DateOfTest.Date == today).Count(y => y.TestIR > 0); // Assuming you want to count non-zero TestIR values

            return value;
        }

        public double GetMonthlyBatteryMeasurements()
        {
            DateTime today = DateTime.Today;

            DateTime sevenDaysAgo = today.AddDays(7);

            var value = _context.CellDetails.Where(x => x.DateOfTest >= sevenDaysAgo && x.DateOfTest <= today).Count(y => y.TestIR > 0);
            return value;
        }

        public double GetWeeklyBatteryMeasurements()
        {
            DateTime today = DateTime.Today;

            DateTime thirtyDaysAgo = today.AddDays(-30);

            var value = _context.CellDetails.Where(x => x.DateOfTest >= thirtyDaysAgo && x.DateOfTest <= today).Count(y => y.TestIR > 0);
            return value;
        }


    }
}
