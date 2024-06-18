using BatteryOptima.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using ProductionOptima.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionOptima.Persistence.Context
{
    public class ProductionOptimaContext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=MONSTER3D;Initial Catalog=BatteryOptimaDb;" +
                "Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;");
        }

        public DbSet<BatteryCell> BatteryCells { get; set; }
        public DbSet<CellDetail> CellDetails { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<UseACell> UseACells { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<CellBox> CellBoxes { get; set; }
        public DbSet<UseACellProcess> UseACellProcesses { get; set; }
    }

}

