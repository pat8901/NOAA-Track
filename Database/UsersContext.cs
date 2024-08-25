using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace NOAA_Track.Database
{

    public class UsersContext : IdentityDbContext
    {
        public UsersContext(DbContextOptions<UsersContext> options) : base(options) { }
    }
}