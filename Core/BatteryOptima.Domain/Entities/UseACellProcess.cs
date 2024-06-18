using ProductionOptima.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BatteryOptima.Domain.Entities
{
    public class UseACellProcess
    {
        public int UseACellProcessId { get; set; }
        public int BatteryCellId { get; set; }
        public BatteryCell BatteryCell { get; set; }
        public int PickUpLocation { get; set; } //pilin alındığı yer
        public int DropOffLocation { get; set; } //pilin bırakıldığı yer
        public DateTime PickUpDate { get; set; } //alma tarih
        public DateTime DropOffDate { get; set; } //bırakma tarih
        public int PersonnelId { get; set; }
        public Personnel Personnel { get; set; }
        public string PickUpDescription { get; set; } //teslim alıp verirken notlar 
        public string DropOffDescription { get; set; }
        

    }
}
