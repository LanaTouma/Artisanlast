using Artisan.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Artisan.Application.ArtisansAppService
{
    public interface IArtisanService
    {
        Task<IEnumerable<Artisans>> GetAllAsync();
        Task<Artisans> GetByIdAsync(int id);
        Task AddAsync(Artisans artisan);
        Task UpdateAsync(Artisans artisan);
        Task DeleteAsync(int id);
        Task<IEnumerable<Artisans>> GetTopRatedArtisansAsync(int count);
    }
}
