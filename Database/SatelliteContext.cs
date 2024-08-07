using Microsoft.EntityFrameworkCore;

namespace NOAA_Track.Database
{
    public class SatelliteContext : DbContext
    {
        public DbSet<Satellite> Satellites { get; set; }

        public SatelliteContext(DbContextOptions<SatelliteContext> options) : base(options)
        {
        }
    }
}