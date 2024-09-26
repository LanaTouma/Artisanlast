using Artisan.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Artisan.Domain.IRepositories
{
    public interface IArtisanRepository : IGenericRepository<Artisans>
    {
        Task<IEnumerable<Artisans>> GetTopRatedArtisansAsync(int count);
        // Only for example, we can decided what other specific methods we need later, Aya
    }
}
