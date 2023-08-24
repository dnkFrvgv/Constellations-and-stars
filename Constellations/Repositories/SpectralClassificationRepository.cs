using Constellations.Data;
using Constellations.Interfaces;
using Constellations.Models;

namespace Constellations.Repositories
{
    public class SpectralClassificationRepository : BaseRepository<SpectralClassification>, ISpectralClassificationRepository
    {
        private readonly AppDbContext _context;
        public SpectralClassificationRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
