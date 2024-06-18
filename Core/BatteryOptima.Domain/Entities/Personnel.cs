using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteryOptima.Domain.Entities
{
    public class Personnel
    {
        public int PersonnelId { get; set; }
        public string PersonnelName { get; set; }
        public string PersonnelSurname { get; set; }
        public string PersonnelMail { get; set; }
        public List<UseACellProcess> UseACellProcesses { get; set; }
    }
}
