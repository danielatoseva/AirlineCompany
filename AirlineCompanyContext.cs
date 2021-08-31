using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AirlineCompany.Models.Airplanes;

namespace AirlineCompany
{
    public class AirlineCompanyContext : DbContext
    {
        public DbSet<Airplane> Airplane { get; set; }
        public DbSet<AirplaneModel> AirplaneModel { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Destination> Destination { get; set; }
        public DbSet<Flight> Flight { get; set; }
        public DbSet<FlightDestinations> FlightDestinations { get; set; }

        public AirlineCompanyContext() { }

        public AirlineCompanyContext(DbContextOptions<AirlineCompanyContext> options) : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(connectionString: @"server=localhost;database=airline_company;uid=root;password=root;",
                new MySqlServerVersion(new Version(10, 4, 17)));
        }
    }
}
