using Constellations.Data;
using Constellations.Interfaces;
using Constellations.Models;

namespace Constellations.Repositories
{
    public class ConstellationRepository : BaseRepository<Constellation>, IConstellationRepository
    {
        private readonly AppDbContext _context;
        public ConstellationRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public void AddRangeStarsToConstellation(IEnumerable<Star> stars, int id)
        {
            Constellation constallation = _context.Constellations.Find(id);
            constallation.AddRangeStars(stars);
        }

        public void AddStarToConstellation(Star star, int id)
        {
            Constellation constallation = _context.Constellations.Find(id);
            constallation.Stars.Add(star);
        }

        public void RemoveRangeStarsFromConstellation(IEnumerable<Star> stars, int id)
        {
            Constellation constallation = _context.Constellations.Find(id);
            constallation.RemoveRangeStars(stars);
        }

        public void RemoveStarFromConstellation(Star star, int id)
        {
            Constellation constallation = _context.Constellations.Find(id);
            constallation.Stars.Remove(star);
        }
    }
}
