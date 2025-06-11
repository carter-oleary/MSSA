using Assignment_10._3.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_10._3.Data
{
    public class CarContext:DbContext
    {
        public DbSet<Car> CarSet { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=GPC;initial catalog=PCAD17Cars;integrated security=True;encrypt=False;trustservercertificate=True;MultipleActiveResultSets=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().HasData(
                new Car
                {
                    VIN = 1,
                    Make = "Honda",
                    Model = "Civic",
                    Year = 2015,
                    Price = 10000
                },
                new Car
                {
                    VIN = 2,
                    Make = "Toyota",
                    Model = "Sienna",
                    Year = 2020,
                    Price = 25000
                },
                new Car
                {
                    VIN = 3,
                    Make = "Mazda",
                    Model = "CX-5",
                    Year = 2025,
                    Price = 50000
                }
            );
        }
    }
}
