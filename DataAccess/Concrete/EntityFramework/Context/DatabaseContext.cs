using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Context
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext()
        {

        }
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        // For Migrations
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer("data source=(localdb)\\mssqllocaldb; initial catalog=Vehicle; Trusted_Connection=true");

        //
        public DbSet<Car> Cars { get; set; }
        public DbSet<Bus> Buses { get; set; }
        public DbSet<Boat> Boats { get; set; }

        // For map
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly); 
           
        }

    }
}
