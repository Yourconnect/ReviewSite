using Microsoft.EntityFrameworkCore;
using ReviewsSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite
{
    public class HauntedHousesContext : DbContext
    {
        public DbSet<HauntedHouse> HauntedHouses { get; set; }
        public DbSet<Review> Reviews { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb; Database=HauntedHouseDB_100621; Trusted_Connection=True";
            optionsBuilder.UseSqlServer(connectionString).UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<HauntedHouse>().HasData(
                new HauntedHouse() {Id = 1, Name = "Carnival Of Horrors", Location = "Canton, Ohio", Price = 24.00, Duration = 30, 
              
                },
                 new HauntedHouse()
                 {
                     Id = 2,
                     Name = "Seven Floors of Hell",
                     Location = "Cleveland, Ohio",
                     Price = 30.00,
                     Duration = 60,
                     
                 },
                 new HauntedHouse()
                 {
                     Id = 3,
                     Name = "Fear Columbus",
                     Location = "Columbus, Ohio",
                     Price = 19.99,
                     Duration = 30,
                 },
                 new HauntedHouse()
                 {
                     Id = 4,
                     Name = "Escape from Blood Prison",
                     Location = "Mansfield, Ohio",
                     Price = 25.00,
                     Duration = 45,
                 },
                  new HauntedHouse()
                  {
                      Id = 5,
                      Name = "Bloodview Haunted House",
                      Location = "Broadview Heights, Ohio",
                      Price =30.00,
                      Duration = 30,
                  }
                );

        }



    }


}
