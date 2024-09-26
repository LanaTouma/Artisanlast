using Artisan.Domain.Entities;
using Artisan.Domain.IRepositories;
using Artisan.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Artisan.Infrastructure.Repositories
{
    public class ArtisanRepository : GenericRepository<Artisans>, IArtisanRepository
    {
        private readonly ArtisanDBContext _context;

        public ArtisanRepository(ArtisanDBContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Artisans>> GetTopRatedArtisansAsync(int count)
        {
            return await _context.Artisans
                .OrderByDescending(a => a.Rating)
                .Take(count)
                .ToListAsync();
        }

        // Again, only for example purposes...
    }
}
