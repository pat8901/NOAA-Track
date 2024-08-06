using Microsoft.EntityFrameworkCore;
using NOAA_Track.Database;

namespace NOAA_Track.Services
{
    public class WeatherService
    {
        private IDbContextFactory<WeatherContext> _dbContextFactory;

        public WeatherService(IDbContextFactory<WeatherContext> dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public async Task AddWeatherEntry()
        {
            using var context = _dbContextFactory.CreateDbContext();
            //await context.
            await Task.Delay(500);
        }
    }
}
