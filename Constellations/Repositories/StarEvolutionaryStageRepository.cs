using Constellations.Models;
using Constellations.Interfaces;
using Constellations.Data;

namespace Constellations.Repositories
{
    public class StarEvolutionaryStageRepository : BaseRepository<StarEvolutionaryStage>, IStarEvolutionaryStageRepository
    {
        private readonly AppDbContext _context;
        public StarEvolutionaryStageRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
