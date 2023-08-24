using Constellations.Models;

namespace Constellations.Interfaces
{
    public interface IStarRepository : IBaseRepository<Star>
    {
        IEnumerable<Star> GetBrightestStars(int count);
        IEnumerable<Star> GetBrightestStarsInSky(int count);
        IEnumerable<Star> GetClosestStarsToEarth(int count);
        IEnumerable<Star> GetStarsByEvolutionaryStage(int evolutionaryStageId, int count);
        IEnumerable<Star> GetStarsInConstellation(int constallationId);
        IEnumerable<Star> GetBrightestStarsInConstelation(int count, int constelllationId);
    }
}
