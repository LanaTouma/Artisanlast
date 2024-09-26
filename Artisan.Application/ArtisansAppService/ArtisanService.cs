using Artisan.Domain.Entities;
using Artisan.Domain.IRepositories;

namespace Artisan.Application.ArtisansAppService
{
    public class ArtisanService : IArtisanService
    {
        private readonly IArtisanRepository _artisanRepository;

        public ArtisanService(IArtisanRepository artisanRepository)
        {
            _artisanRepository = artisanRepository;
        }

        public async Task<IEnumerable<Artisans>> GetAllAsync()
        {
            return await _artisanRepository.GetAllAsync();
        }

        public async Task<Artisans> GetByIdAsync(int id)
        {
            return await _artisanRepository.GetByIdAsync(id);
        }

        public async Task AddAsync(Artisans artisan)
        {
            await _artisanRepository.AddAsync(artisan);
        }

        public async Task UpdateAsync(Artisans artisan)
        {
            await _artisanRepository.UpdateAsync(artisan);
        }

        public async Task DeleteAsync(int id)
        {
            await _artisanRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Artisans>> GetTopRatedArtisansAsync(int count)
        {
            return await _artisanRepository.GetTopRatedArtisansAsync(count);
        }
    }
}
