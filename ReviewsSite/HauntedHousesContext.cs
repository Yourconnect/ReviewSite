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

        }


    }


}
