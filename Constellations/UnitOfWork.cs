using Constellations.Data;
using Constellations.Interfaces;

namespace Constellations
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }
        public void CommitChanges()
        {
            _context.SaveChanges();
        }
    }
}
