using Microsoft.EntityFrameworkCore;
using justmotors.Models;

namespace justmotors.Persistence
{
    public class JustmotorsDbContext : DbContext
    {
        public DbSet<Make> Makes { get; set; }
        public DbSet<Feature> Features { get; set; }
        public JustmotorsDbContext(DbContextOptions<JustmotorsDbContext> options)
            : base (options)
        {
        }

        protected override void OnModelCreating(ModelBuilder moduleBuilder)
        {
            // creating composite key (combo of VechileId + FeatureId)
            moduleBuilder.Entity<VehicleFeature>().HasKey(vf =>
                 new { vf.VehicleId, vf.FeatureId });
        }
    }
}