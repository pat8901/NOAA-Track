using Microsoft.EntityFrameworkCore;
using NOAA_Track.Models;

namespace NOAA_Track.Database
{
    public class WeatherContext : DbContext
    {
        public DbSet<Weather> Observations { get; set; }

        public WeatherContext(DbContextOptions options) : base(options)
        {
        }
    }
}