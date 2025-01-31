using E_Belediye.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace E_Belediye.Repository
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
        
        }

        public DbSet<DailyTraffic> DailyTraffics { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<MessageBox> MessageBoxs { get; set; }
        public DbSet<Officer> Officers { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Reminder> Reminders { get; set; }
        public DbSet<TaskProcess> TaskProcesses { get; set; }
        public DbSet<TrafficData> TrafficDatas { get; set; }
        public DbSet<UnitLead> UnitLeads { get; set; }
        public DbSet<WorkingUnit> WorkingUnits { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }

        /*TRAFIK EKLEME ISLEMI ICIN TRIGGER KISMI*/

        //public override int SaveChanges()
        //{
        //    var addedTrafficData = ChangeTracker.Entries<TrafficData>()
        //        .Where(e => e.State == EntityState.Added)
        //        .Select(e => e.Entity)
        //        .ToList();

        //    var dailyTrafficSet = Set<DailyTraffic>();

        //    foreach (var traffic in addedTrafficData)
        //    {
        //        var dailyTraffic = dailyTrafficSet.FirstOrDefault(dt => dt.Date == traffic.Date);

        //        if (dailyTraffic == null)
        //        {
        //            dailyTrafficSet.Add(new DailyTraffic
        //            {
        //                Date = traffic.Date,
        //                TotalTraffic = 1
        //            });
        //        }
        //        else
        //        {
        //            dailyTraffic.TotalTraffic += 1;
        //        }
        //    }

        //    return base.SaveChanges();
        //}
    }
}
