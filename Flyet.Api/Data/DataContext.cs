using Flyet.Api.Models;
using Flyet.Models;
using Microsoft.EntityFrameworkCore;

namespace Flyet.Api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Flight> Flights { get; set; }
        public DbSet<Airship> Airships { get; set; }
        public DbSet<Airport> Airports { get; set; }
    }
}
