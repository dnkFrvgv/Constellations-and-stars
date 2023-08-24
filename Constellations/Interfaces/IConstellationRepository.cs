using Constellations.Models;

namespace Constellations.Interfaces
{
    public interface IConstellationRepository : IBaseRepository<Constellation>
    {
        void AddStarToConstellation(Star star, int id);        
        void AddRangeStarsToConstellation(IEnumerable<Star> stars, int id);
        void RemoveStarFromConstellation(Star star, int id);
        void RemoveRangeStarsFromConstellation(IEnumerable<Star> stars, int id);
    }
}
