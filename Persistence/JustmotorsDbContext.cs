using Microsoft.EntityFrameworkCore;
using justmotors.Models;

namespace justmotors.Persistence
{
    public class JustmotorsDbContext : DbContext
    {
        public JustmotorsDbContext(DbContextOptions<JustmotorsDbContext> options)
            : base (options)
        {
        }

        public DbSet<Make> Makes { get; set; }
        public DbSet<Feature> Features { get; set; }
    }
}