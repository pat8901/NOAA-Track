using Microsoft.EntityFrameworkCore;
using NOAA_Track.Database;

namespace NOAA_Track.Services
{
    public class SatelliteService
    {
        private IDbContextFactory<SatelliteContext> _dbContextFactory;

        public SatelliteService(IDbContextFactory<SatelliteContext> dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        // TODO: Do not allow duplicates
        public async Task AddSatellite(Satellite satellite)
        {
            using var context = _dbContextFactory.CreateDbContext();
            await context.Satellites.AddAsync(satellite);
            await context.SaveChangesAsync();
        }

        public Satellite GetSatelliteByName(string name)
        {
            using var context = _dbContextFactory.CreateDbContext();
            var satellite = context.Satellites.SingleOrDefault(x => x.Name == name);
            // Remember to preform null check to handle null values.
            return satellite;
        }

        public async Task<List<Satellite>> GetSatellites()
        {
            using var context = _dbContextFactory.CreateDbContext();
            var satellites = await context.Satellites.ToListAsync();
            if (satellites == null)
            {
                throw new Exception("Satellite database is empty!");
            }
            return satellites;
        }

        public void UpdateSatellite(string name, string new_name)
        {
            using var context = _dbContextFactory.CreateDbContext();
            var satellite = GetSatelliteByName(name);
            if (satellite == null)
            {
                throw new Exception("Satellite does not exist!");
            }
            satellite.Name = new_name;
            satellite.LaunchDate = DateTime.Now;

            context.Update(satellite);
            context.SaveChanges();
        }

        public async Task DeleteSatellite(string name)
        {
            using var context = _dbContextFactory.CreateDbContext();
            var satellite = await context.Satellites.SingleOrDefaultAsync(x => x.Name == name);
            //var satellite = await context.Satellites.FindAsync(x => x.Name == name);
            if (satellite == null)
            {
                throw new Exception("Entry not found!");
            }
            context.Satellites.Remove(satellite);
            await context.SaveChangesAsync();
        }
    }
}