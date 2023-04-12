using Backend.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Backend.Context
{
    public class GestaoContext : DbContext
    {
        GestaoContext(DbContextOptions options) : base(options) 
        {
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Diary> Diaries { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Garage> Garages { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Slot> Slots { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserDiary> UsersDiaries { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleType> VehiclesTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().UseTptMappingStrategy();
            base.OnModelCreating(modelBuilder);
        }
    }
}
