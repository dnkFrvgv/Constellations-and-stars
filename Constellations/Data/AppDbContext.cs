using Constellations.Models;
using Microsoft.EntityFrameworkCore;

namespace Constellations.Data
{
    public class AppDbContext : DbContext
    { 
        public AppDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Constellation> Constellations { get; set; }
        public DbSet<Star> Stars { get; set; }
        public DbSet<SpectralClassification> SpectralClassifications { get; set; }
        public DbSet<StarEvolutionaryStage> EvolutionaryStages { get; set; }
    }
}
