using Microsoft.EntityFrameworkCore;
using ScheduleTime.DataBase.MapDataBase;
using ScheduleTime.Domain.Entities;

namespace ScheduleTime.DataBase.Context
{
    public class AppDbContext : DbContext
    {
        private AppDbContext() { }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        public DbSet<BarberShop> BarberShops { get; set; }
        public DbSet<BeautySalon> BeautySalons { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Schedule> Schedules { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BarberShopMap());
            modelBuilder.ApplyConfiguration(new BeautySalonMap());
            modelBuilder.ApplyConfiguration(new ScheduleMap());
            modelBuilder.ApplyConfiguration(new CustomerMap());
        }
    }
}
