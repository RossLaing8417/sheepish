using Microsoft.EntityFrameworkCore;
using Sheepish.Entities;

namespace Sheepish.DataAccess.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Scenario> Scenarios { get; set; }
        public DbSet<DailyRecord> DailyRecords { get; set; }
        public DbSet<DailySheepRecord> DailySheepRecords { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
}
