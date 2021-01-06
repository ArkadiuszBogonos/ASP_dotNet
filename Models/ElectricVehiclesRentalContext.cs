using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WypozyczalniaPojazdowElektrycznych3.Models
{
    public class ElectricVehiclesRentalContext : DbContext
    {
        public ElectricVehiclesRentalContext(DbContextOptions<ElectricVehiclesRentalContext> options): base(options)
        {

        }


        public DbSet<Category> Categories {get; set;}
        public DbSet<Manufacturer> Manufacturers { get; set;}
        public DbSet<Model> Models {get; set;}
        public DbSet<Vehicle> Vehicles {get; set;}
    }
}
