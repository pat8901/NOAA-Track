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

        public async Task AddWeatherEntry(Weather observation)
        {
            using var context = _dbContextFactory.CreateDbContext();
            await context.Observations.AddAsync(observation);
            await context.SaveChangesAsync();
        }

        public async Task<Weather?> CheckWeatherExist(string search_string)
        {
            using var context = _dbContextFactory.CreateDbContext();
            var observation = await context.Observations.SingleOrDefaultAsync(x => x.timestamp == search_string);
            return observation;
        }

        public async Task<List<Weather>> GetObservations()
        {
            using var context = _dbContextFactory.CreateDbContext();
            return await context.Observations.ToListAsync();
        }
    }
}
