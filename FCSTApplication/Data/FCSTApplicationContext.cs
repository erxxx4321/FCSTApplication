using Microsoft.EntityFrameworkCore;
using FCSTApplication.Models;

namespace FCSTApplication.Data
{
    public class FCSTApplicationContext : DbContext
    {
        public FCSTApplicationContext(DbContextOptions<FCSTApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<StarchData> StarchData { get; set; }
        public DbSet<CoalData> CoalData { get; set; }
    }
}
