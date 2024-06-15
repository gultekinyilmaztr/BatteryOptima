using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteryOptima.Dto.StatisticsDtos
{
    public class ResultStatisticsDto
    {
        public int cellCount { get; set; }
        public double dailyBatteryMeasurement { get; set; }
        public double weeklyBatteryMeasurement { get; set; }
        public double monthlyBatteryMeasurement { get; set; }
        public int countofDamagedBatteries { get; set; }
        public int countofWasteBatteries { get; set; }
        public int countofUsedBatteries { get; set; }
        public int countofNonUsedBatteries { get; set; }
        public int countofBatteriesAboveToleranceValue { get; set; }
    }
}
