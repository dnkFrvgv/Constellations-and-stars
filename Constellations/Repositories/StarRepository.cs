using Constellations.Data;
using Constellations.Interfaces;
using Constellations.Models;
using Microsoft.EntityFrameworkCore;

namespace Constellations.Repositories
{
    public class StarRepository : BaseRepository<Star>, IStarRepository
    {
        private readonly AppDbContext _context;
        public StarRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<Star> GetBrightestStars(int count)
        {
            return _context.Stars.OrderBy(s=>s.AbsoluteMagnitude).Take(count).ToList();
        }

        public IEnumerable<Star> GetBrightestStarsInConstelation(int count, int constelllationId)
        {
            return _context.Stars.Where(s => s.ConstallationId == constelllationId).OrderBy(s => s.ApparentMagnitude).Take(count).ToList();
        }

        public IEnumerable<Star> GetBrightestStarsInSky(int count)
        {
            return _context.Stars.OrderBy(s=>s.ApparentMagnitude).Include(s=>s.Constellation).Take(count).ToList();
        }

        public IEnumerable<Star> GetClosestStarsToEarth(int count)
        {
            return _context.Stars.OrderBy(s => s.ApproximateDistanceFromEarthLightYrs).Take(count).ToList();
        }

        public IEnumerable<Star> GetStarsByEvolutionaryStage(int evolutionaryStageId, int count)
        {
            return _context.Stars.Where(s=>s.EvolutionaryStageId == evolutionaryStageId).Take(count).ToList();
        }

        public IEnumerable<Star> GetStarsInConstellation(int constallationId)
        {
            return _context.Stars.Where(s => s.ConstallationId == constallationId).ToList();
        }
    }
}
