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
            moduleBuilder.Entity<VechileFeature>().HasKey(vf =>
                 new { vf.VechileId, vf.FeatureId});
        }
    }
}