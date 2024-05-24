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
            optionsBuilder.UseSqlServer("Data Source=ZY-N036-V15\\SQLEXPRESS;Initial" +
                " Catalog=BatteryOptimaDb;Integrated Security=True;" +
                "Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;" +
                "Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        public DbSet<BatteryCell> BatteryCells { get; set; }
        public DbSet<CellDetail> CellDetails { get; set; }
        public DbSet<Producer> Producers { get; set; }
    }

}
